using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClosedXML.Excel.XLPredefinedFormat;

namespace AppGestionTFG

{
    internal class FuncionesBD
    {

        static string connString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        SqlConnection conn = new SqlConnection(connString);


        public int insertar(string tabla, List<string> atb, List<string> valores, string output)
        {
            string strsql = "INSERT INTO " + tabla + " (" + string.Join(", ", atb) + ") ";

            if (output != null)
            {
                strsql += "OUTPUT INSERTED." + output;
            }
            
            strsql += " VALUES (" + string.Join(", ", valores) + ")";

            int ins = 0;
            conn.Open();

            SqlCommand cmd = new SqlCommand(strsql, conn);

            if (output != null)
            {
                ins = (int)cmd.ExecuteScalar();
            }
            else { cmd.ExecuteNonQuery(); }

            conn.Close();

            return ins;
        }

        public int eliminar(string tabla, List<string> cond)
        {
            string strsql = "DELETE FROM " + tabla + " WHERE (" + string.Join(" AND ", cond) + ")";

            int del;
            conn.Open();

            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                del = cmd.ExecuteNonQuery();
            }

            conn.Close();

            return del;
        }

        public DataTable getSelect(string tabla, List<string> atb, List<string> cond, string order)
        {

            SqlConnection conn = new SqlConnection(connString);

            conn.Open();

            string strsql = "SELECT " + string.Join(", ", atb) + " FROM " + tabla;
            
            if (cond != null)
            {
                strsql += " where " + string.Join(" AND ", cond);

                if (order != null && order != "")
                {
                    strsql += " ORDER BY " + string.Join(", ", order);
                }
            }


            


            SqlCommand cmd = new SqlCommand(strsql, conn);

            DataTable datos = new DataTable();

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(datos);
            }


            conn.Close();

            return datos;
        }

        public int actualizar(string tabla, List<string> atb, List<string> cond, string output)
        {
            string strsql = "UPDATE " + tabla + " SET " + string.Join(", ", atb) + " ";

            if (output != null)
            {
                strsql += "OUTPUT INSERTED." + output;
            }

            strsql += " WHERE (" + string.Join("AND ", cond) + ")";

            int upd = 0;
            conn.Open();

            SqlCommand cmd = new SqlCommand(strsql, conn);

            if (output != null)
            {
                upd = (int)cmd.ExecuteScalar();
            }
            else { cmd.ExecuteNonQuery(); }

            conn.Close();

            return upd;
        }



        public string obtenerPrivilegiosUsuario(string user, string pass)
        {
            string priv = "";

            SqlConnection conn = new SqlConnection(connString);

            conn.Open();

            string strsql = "SELECT priv FROM tfgdb.dbo.USUARIOS_PRIV where usuario = '" + user + "' and pass = '" + pass + "'";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            DataTable table = new DataTable();

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(table);
            }

            if (table.Rows.Count != 0)
            {
                priv = table.Rows[0][0].ToString();
            }
            else
            {
                priv = "DENIED";
            }


            conn.Close();

            return priv;
        }

        public DataTable obtenerPersonal()
        {
            DataTable personal = new DataTable();

            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter1 = new SqlDataAdapter();

            conn.Open();

            string strsql = "SELECT ID_PERSONAL, CONCAT (NOMBRE, ' ',  APELLIDO1, ' ', APELLIDO2) AS NOMBRE, DNI, (select nombre from rrhh_db.dbo.DEPARTAMENTOS where id = id_departamento) as DEPARTAMENTO, (select nombre from rrhh_db.dbo.PUESTOS where id_puesto = PUESTO) as PUESTO, f_alta AS FECHA_ALTA FROM rrhh_db.dbo.PERSONAL where f_baja is null";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(personal);
            }

            conn.Close();

            return personal;
        }

        public DataTable obtenerPersonaID(string id)
        {
            DataTable personal = new DataTable();

            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter1 = new SqlDataAdapter();

            conn.Open();

            string strsql = "SELECT ID_PERSONAL, NOMBRE, APELLIDO1, APELLIDO2, DNI, (select nombre from rrhh_db.dbo.DEPARTAMENTOS where id = id_departamento) as DEPARTAMENTO, (select nombre from rrhh_db.dbo.PUESTOS where id_puesto = PUESTO) as PUESTO, f_alta AS FECHA_ALTA FROM rrhh_db.dbo.PERSONAL where ID_PERSONAL = " + id;
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(personal);
            }

            conn.Close();

            return personal;
        }
        public DataTable obtenerDepartamentos()
        {
            DataTable dpt = new DataTable();

            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter1 = new SqlDataAdapter();

            conn.Open();

            string strsql = "SELECT NOMBRE FROM rrhh_db.dbo.DEPARTAMENTOS";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(dpt);
            }

            conn.Close();

            return dpt;
        }

        public DataTable obtenerPuestos()
        {
            DataTable puestos = new DataTable();

            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter1 = new SqlDataAdapter();

            conn.Open();

            string strsql = "SELECT NOMBRE FROM rrhh_db.dbo.PUESTOS";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(puestos);
            }

            conn.Close();

            return puestos;
        }

        public int insertarPersonal(string nombre, string ap1, string ap2, string dni, string puesto, string dpto)
        {
            SqlConnection conn = new SqlConnection(connString);
            int ins;

            conn.Open();

            string strsql = "INSERT INTO rrhh_db.dbo.PERSONAL (NOMBRE, APELLIDO1, APELLIDO2, DNI, ID_DEPARTAMENTO, PUESTO, F_ALTA) VALUES ('" + nombre + "', '" + ap1 + "', '" + ap2 + "','" + dni + "','" + dpto + "','" + puesto + "', GETDATE()) ";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                ins = cmd.ExecuteNonQuery();
            }

            conn.Close();

            return ins;
        }

        public int actualizarPersonal(string nombre, string ap1, string ap2, string dni, string puesto, string dpto, string id)
        {
            SqlConnection conn = new SqlConnection(connString);
            int ins;

            conn.Open();

            string strsql = "UPDATE rrhh_db.dbo.PERSONAL SET NOMBRE = '" + nombre + "', APELLIDO1 = '" + ap1 + "', APELLIDO2 = '" + ap2 + "', DNI = '" + dni + "', ID_DEPARTAMENTO = '" + dpto + "', PUESTO = '" + puesto + "' where ID_PERSONAL = '" + id + "'";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                ins = cmd.ExecuteNonQuery();
            }

            conn.Close();

            return ins;
        }

        public string getDpto(int id)
        {
            DataTable dpt = new DataTable();
            string nDept = "-";

            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter1 = new SqlDataAdapter();

            conn.Open();

            string strsql = "SELECT nombre FROM rrhh_db.dbo.DEPARTAMENTOS where ID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(dpt);
            }

            conn.Close();

            if (dpt.Rows.Count > 0 )
            {
                nDept = dpt.Rows[0][0].ToString();
            }

            return nDept;

        }

        public string getDptoID(string nombre)
        {
            DataTable dpt = new DataTable();
            string nDept = "0";

            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter1 = new SqlDataAdapter();

            conn.Open();

            string strsql = "SELECT ID FROM rrhh_db.dbo.DEPARTAMENTOS where nombre = '" + nombre + "'";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(dpt);
            }

            conn.Close();

            if (dpt.Rows.Count > 0)
            {
                nDept = dpt.Rows[0][0].ToString();
            }

            return nDept;

        }

        public string getPuesto(int id)
        {
            DataTable puesto = new DataTable();
            string nDept = "-";

            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter1 = new SqlDataAdapter();

            conn.Open();

            string strsql = "SELECT nombre FROM rrhh_db.dbo.DEPARTAMENTOS where ID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(puesto);
            }

            conn.Close();

            if (puesto.Rows.Count > 0)
            {
                nDept = puesto.Rows[0][0].ToString();
            }

            return nDept;

        }

        public string getPuestoID(string nombre)
        {
            DataTable puesto = new DataTable();
            string nDept = "0";

            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter1 = new SqlDataAdapter();

            conn.Open();

            string strsql = "SELECT ID_PUESTO FROM rrhh_db.dbo.PUESTOS where nombre = '" + nombre + "'";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(puesto);
            }

            conn.Close();

            if (puesto.Rows.Count > 0)
            {
                nDept = puesto.Rows[0][0].ToString();
            }

            return nDept;

        }


        public DataTable getArticulos()
        {
            DataTable dt = new DataTable();

            DataTable articulos = new DataTable();

            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter1 = new SqlDataAdapter();

            conn.Open();

            string strsql = "select a.ID, CODIGO, DENOMINACION, c.CATEGORIA, p.NOMBRE as PROVEEDOR, a.FECHA_C as FECHA_ENTRADA, STOCK from tfgdb.dbo.ARTICULOS_MP a left join tfgdb.dbo.CATEGORIAS_MP c on a.CATEGORIA = c.ID_CATEGORIA left join tfgdb.dbo.PROVEEDORES p on p.ID = a.PROVEEDOR";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(articulos);
            }

            conn.Close();

            return articulos;

        }

        public int insertArticulo(string codigo, string denomi, string cat, string prov, string stock)
        {
            SqlConnection conn = new SqlConnection(connString);
            int ins;
            conn.Open();

            string strsql = "INSERT INTO tfgdb.dbo.ARTICULOS_MP (CODIGO, DENOMINACION, CATEGORIA, PROVEEDOR, STOCK, FECHA_C) VALUES ('" + codigo + "', '" + denomi + "', '" + cat + "','" + prov + "','" + stock + "', GETDATE()) ";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                ins = cmd.ExecuteNonQuery();
            }

            conn.Close();

            return ins;
        }

        public int updateArticulo(string codigo, string denomi, string cat, string prov, string stock, int ID)
        {
            SqlConnection conn = new SqlConnection(connString);
            int upd;
            conn.Open();

            string strsql = "UPDATE tfgdb.dbo.ARTICULOS_MP SET CODIGO = '" + codigo + "', DENOMINACION = '" + denomi + "', CATEGORIA = '" + cat + "', PROVEEDOR = '" + prov + "', STOCK = '" + stock + "' WHERE ID = " + ID;
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                upd = cmd.ExecuteNonQuery();
            }

            conn.Close();

            return upd;
        }

        public void eliminarArticulo(string codigo)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string strsql = "DELETE FROM tfgdb.dbo.ARTICULOS_MP WHERE CODIGO = '" + codigo + "'";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }

        public DataTable getCatego()
        {
            DataTable dt = new DataTable();

            DataTable catego = new DataTable();

            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter1 = new SqlDataAdapter();

            conn.Open();

            string strsql = "select CATEGORIA, ID_CATEGORIA from tfgdb.dbo.CATEGORIAS_MP";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(catego);
            }

            conn.Close();

            return catego;

        }

        public DataTable getProvs()
        {
            DataTable provs = new DataTable();

            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter1 = new SqlDataAdapter();

            conn.Open();

            string strsql = "select NOMBRE, ID from tfgdb.dbo.PROVEEDORES";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(provs);
            }

            conn.Close();

            return provs;

        }

        //MP PAQUETES
        public DataTable getPaquetes(System.DateTime fechadesde, System.DateTime fechahasta)
        {
            DataTable paqs = new DataTable();

            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter1 = new SqlDataAdapter();

            conn.Open();

            string strsql = "select distinct pea.N_PAQUETE as PAQUETE, ";
            strsql += "(select top (1) PARCELA from tfgdb.dbo.PAQUETES_ENTRADA_ALMACEN where N_PAQUETE = pea.N_PAQUETE order by FECHA_RECP desc) as PARCELA, ";
            strsql += "(select top (1) FECHA_RECP FROM tfgdb.dbo.PAQUETES_ENTRADA_ALMACEN where N_PAQUETE = pea.N_PAQUETE order by FECHA_RECP ASC) as [FECHA DE ENTRADA] ";
            strsql += "from tfgdb.dbo.PAQUETES_ENTRADA_ALMACEN pea where '" + fechadesde.Date.ToString("dd-MM-yyyy") + "' <= FECHA_RECP and  FECHA_RECP <= '" + fechahasta.Date.ToString("dd-MM-yyyy") + "'";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(paqs);
            }

            conn.Close();

            return paqs;
        }

        public DataTable getMPPaquetes(string paquete)
        {
            DataTable paqs = new DataTable();

            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter1 = new SqlDataAdapter();

            conn.Open();

            string strsql = "select PAQUETE, ARTICULO, CANTIDAD as CTD, CMP.CATEGORIA, DENOMINACION from tfgdb.dbo.PAQUETES_MP pmp ";
            strsql += "left join tfgdb.dbo.ARTICULOS_MP amp on amp.CODIGO = pmp.ARTICULO ";
            strsql += "left join tfgdb.dbo.CATEGORIAS_MP cmp on cmp.ID_CATEGORIA = amp.CATEGORIA where PAQUETE = " + paquete;


            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(paqs);
            }

            conn.Close();

            return paqs;
        }

        public string getEstadoPaquete(string paquete)
        {
            DataTable paqs = new DataTable();

            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter1 = new SqlDataAdapter();

            conn.Open();

            string strsql = "select TOP (1) case when CONFIRMADO IS null then 'PENDIENTE' ELSE CONFIRMADO END AS ESTADO from tfgdb.dbo.PAQUETES_ENTRADA_ALMACEN where N_PAQUETE =  " + paquete + " order by FECHA_RECP desc";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(paqs);
            }

            conn.Close();

            return paqs.Rows[0][0].ToString();
        }

        public DataTable getInfoMP(string codigo)
        {
            DataTable info = new DataTable();

            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter1 = new SqlDataAdapter();

            conn.Open();

            string strsql = "select codigo, DENOMINACION, cat.CATEGORIA, pro.NOMBRE from tfgdb.dbo.ARTICULOS_MP mp left join tfgdb.dbo.CATEGORIAS_MP cat on mp.CATEGORIA = cat.ID_CATEGORIA left join tfgdb.dbo.PROVEEDORES pro on pro.ID = mp.PROVEEDOR where CODIGO = '" + codigo + "'";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(info);
            }

            conn.Close();

            return info;
        }

        public int añadirMPPaquete(string paquete, string codigo, int cantidad)
        {
            SqlConnection conn = new SqlConnection(connString);
            int ins;

            try
            {
                conn.Open();

                string strsql = "INSERT INTO tfgdb.dbo.PAQUETES_MP (PAQUETE, ARTICULO, CANTIDAD, FECHA_C) VALUES ('" + paquete + "', '" + codigo + "', '" + cantidad + "', GETDATE()) ";
                SqlCommand cmd = new SqlCommand(strsql, conn);

                using (conn)
                {
                    ins = cmd.ExecuteNonQuery();
                }

                conn.Close();

                return ins;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                return -1;
            }

        }

        public void confirmarPaqueteMP(string paquete)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string strsql = "INSERT INTO tfgdb.dbo.PAQUETES_ENTRADA_ALMACEN (PARCELA, N_PAQUETE, USUARIO_C, FECHA_RECP, CONFIRMADO, COD_ALMACEN) SELECT TOP (1) PARCELA, N_PAQUETE, '" + Environment.UserName + "' as USUARIO_C, GETDATE() AS FECHA_RECP, 'CONFIRMADO' , COD_ALMACEN FROM tfgdb.dbo.PAQUETES_ENTRADA_ALMACEN WHERE N_PAQUETE = '" + paquete + "' ORDER BY FECHA_RECP DESC";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }

        public void eliminarMPPaquete(string articulo, string paquete)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string strsql = "DELETE FROM tfgdb.dbo.PAQUETES_MP WHERE PAQUETE = '" + paquete + "' AND ARTICULO = '" + articulo + "' ";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }

        public void editarMPPaquete(string paquete, string articulo, int cantidad)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string strsql = "UPDATE tfgdb.dbo.PAQUETES_MP SET PAQUETE = '" + paquete + "', ARTICULO = '" + articulo + "', CANTIDAD = '" + cantidad + "' WHERE PAQUETE = '" + paquete + "' AND ARTICULO = '" + articulo + "'";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            using (conn)
            {
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }

        //PAQUETES ALMACÉN
        public DataTable obtenerAlmacenes()
        {
            string strsql;
            SqlCommand comando;
            SqlDataAdapter adapter;
            DataTable table = null;


            try
            {

                conn.Open();

                strsql = "";
                strsql = strsql + " select DISTINCT NOMBRE, COD_ALMACEN from tfgdb.dbo.ALMACENES";

                comando = new SqlCommand(strsql, conn);
                adapter = new SqlDataAdapter(comando);
                table = new DataTable();
                adapter.Fill(table);

                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();


                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return table;
        }

        public DataTable obtenerDatosParcelas(string codalm)
        {
            SqlCommand comando;
            SqlDataAdapter adapter;
            DataTable table = null;
            string strsql = "";

            try
            {

                conn.Open();

                strsql = "";
                strsql = strsql + " select nave, fila, columna from tfgdb.dbo.PARCELAS_ALMACEN";
                strsql = strsql + " WHERE COD_ALMACEN = '" + codalm + "'";

                comando = new SqlCommand(strsql, conn);
                adapter = new SqlDataAdapter(comando);
                table = new DataTable();
                adapter.Fill(table);

                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();


                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return table;
        }
        

        

        public bool checkMismaParcela(string paq, string parcela, string codalm)
        {
            bool mismaParcela = false;

            SqlCommand comando;
            SqlDataReader reader;
            string strsql = "";

            try
            {

                conn.Open();


                strsql = "";
                strsql = strsql + " select * FROM tfgdb.dbo.PAQUETES_ENTRADA_ALMACEN";
                strsql = strsql + " WHERE   COD_ALMACEN = '" + codalm + "' AND N_PAQUETE = '" + paq + "' ";
                strsql = strsql + " ORDER BY FECHA_RECP DESC";


                comando = new SqlCommand(strsql, conn);
                reader = comando.ExecuteReader();

                string parcelaCons;

                if (reader.Read())
                {
                    parcelaCons = reader["parcela"].ToString();

                    if (parcelaCons == parcela)
                    {
                        mismaParcela = true;
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();


                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return mismaParcela;
        }

        public void guardarParcela(string paq, string codalm, string[] parcela)
        {
            SqlCommand comando;
            string strsql = "";

            try
            {
                conn.Open();



                strsql = "";
                strsql = strsql + " INSERT INTO tfgdb.dbo.PAQUETES_ENTRADA_ALMACEN (N_PAQUETE, COD_ALMACEN, PARCELA, USUARIO_C, FECHA_RECP) ";
                strsql = strsql + " VALUES ('" + paq + "', '" + codalm + "', '" + string.Join("", parcela) + "', '" + Environment.UserName + "', getdate())";

                comando = new SqlCommand(strsql, conn);
                comando.ExecuteNonQuery();



                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();


                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable historialPaquete(string codalm, string paq)
        {
            string strsql;
            SqlCommand comando;
            SqlDataAdapter adapter;
            DataTable table = null;


            try
            {

                conn.Open();



                strsql = "";
                strsql = strsql + " select PARCELA, (SELECT TOP (1) NOMBRE FROM tfgdb.dbo.ALMACENES alm WHERE alm.COD_ALMACEN = pea.COD_ALMACEN) as ALMACEN, FECHA_RECP from tfgdb.dbo.PAQUETES_ENTRADA_ALMACEN pea";
                strsql = strsql + " WHERE N_PAQUETE = '" + paq + "' ORDER BY FECHA_RECP DESC";

                comando = new SqlCommand(strsql, conn);
                adapter = new SqlDataAdapter(comando);
                table = new DataTable();
                adapter.Fill(table);

                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();


                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return table;
        }

        //GESTIÓN PROYECTOS

        public DataTable obtenerProys()
        {
            SqlCommand comando;
            SqlDataAdapter adapter;
            DataTable table = null;
            string strsql = "";

            try
            {
                conn.ConnectionString = connString;
                conn.Open();

                strsql = "";
                strsql = strsql + " SELECT *  FROM tfgdb.dbo.PROYECTOS WHERE ESTADO <> 'FINALIZADO' ORDER BY ID_PROY";

                comando = new SqlCommand(strsql, conn);
                adapter = new SqlDataAdapter(comando);
                table = new DataTable();
                adapter.Fill(table);

                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();


                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return table;
        }

        public DataTable obtenerEstructs(string proy)
        {
            SqlCommand comando;
            SqlDataAdapter adapter;
            DataTable table = null;
            string strsql = "";

            try
            {

                conn.Open();

                strsql = "";
                strsql = strsql + " SELECT *  FROM tfgdb.dbo.PIEZAS WHERE ID_PROYECTO = '" + proy + "' ORDER BY CODIGO_PADRE, CODIGO";

                comando = new SqlCommand(strsql, conn);
                adapter = new SqlDataAdapter(comando);
                table = new DataTable();
                adapter.Fill(table);

                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();


                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return table;
        }

        public DataTable obtenerOperaciones()
        {
            SqlCommand comando;
            SqlDataAdapter adapter;
            DataTable table = null;
            string strsql = "";

            try
            {

                conn.Open();

                strsql = "";
                strsql = strsql + " select DISTINCT * from tfgdb.dbo.TIPOS_OPER";

                comando = new SqlCommand(strsql, conn);
                adapter = new SqlDataAdapter(comando);
                table = new DataTable();
                adapter.Fill(table);

                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();


                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return table;
        }

        public DataTable obtenerComponentesMP(string pieza, string proy)
        {
            SqlCommand comando;
            SqlDataAdapter adapter;
            DataTable table = null;
            string strsql = "";

            try
            {

                conn.Open();

                strsql = "";
                strsql = strsql + " select MP_BASE as [ARTÍCULO MP BASE], DNI_EMP_ASIGNADO AS [EMPLEADO ASIGNADO], NOMBRE_OPERACION AS [OPERACIÓN] from tfgdb.dbo.OPERACIONES op left join tfgdb.dbo.TIPOS_OPER tp on tp.ID_OPERACION = op.OPERACION where PIEZA = '" + pieza + "' and PROYECTO = '" + proy + "'";

                comando = new SqlCommand(strsql, conn);
                adapter = new SqlDataAdapter(comando);
                table = new DataTable();
                adapter.Fill(table);

                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();


                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return table;
        }

        public void nuevaOperacion(string pieza, string articulo, string proy, string dni_emp, string op)
        {
            SqlCommand comando;
            string strsql = "";

            try
            {

                conn.Open();

                strsql = "";
                strsql = strsql + "insert into tfgdb.dbo.OPERACIONES (PROYECTO, PIEZA, OPERACION, DNI_EMP_ASIGNADO, FECHA_CRE, MP_BASE) values ('" + proy + "', '" + pieza + "', '" + op + "','" + dni_emp + "',GETDATE(), '" + articulo + "')";

                comando = new SqlCommand(strsql, conn);
                comando.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();


                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarOperacion(string pieza, string articulo, string proy, string op)
        {
            SqlCommand comando;
            string strsql = "";

            try
            {

                conn.Open();

                strsql = "";
                strsql = strsql + "delete from tfgdb.dbo.OPERACIONES where PROYECTO = '" + proy + "' and PIEZA = '" + pieza + "' AND MP_BASE = '" + articulo + "' AND OPERACION = (SELECT TOP (1) ID_OPERACION FROM tfgdb.dbo.TIPOS_OPER WHERE NOMBRE_OPERACION = '" + op + "')";

                comando = new SqlCommand(strsql, conn);
                comando.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();


                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void nuevaPieza(string pieza, string desc, string proy, string padre)
        {
            SqlCommand comando;
            string strsql = "";

            try
            {

                conn.Open();

                strsql = "";
                strsql = strsql + "insert into tfgdb.dbo.PIEZAS (CODIGO, DESCRIPCION, ID_PROYECTO, CODIGO_PADRE, FECHA_CRE, USUARIO_CRE) values ('" + pieza + "', '" + desc + "', '" + proy + "','" + padre + "',GETDATE(), '" + Environment.UserName + "')";

                comando = new SqlCommand(strsql, conn);
                comando.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();


                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarPieza(string pieza, string proy, string padre)
        {
            SqlCommand comando;
            string strsql = "";

            try
            {

                conn.Open();

                strsql = "";
                strsql = strsql + "delete from tfgdb.dbo.PIEZAS where ID_PROYECTO = '" + proy + "' and CODIGO = '" + pieza + "' AND CODIGO_PADRE = '" + padre + "'";

                comando = new SqlCommand(strsql, conn);
                comando.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();


                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }

    
}
