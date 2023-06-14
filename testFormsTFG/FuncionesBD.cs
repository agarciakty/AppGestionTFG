using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionTFG

{
    internal class FuncionesBD
    {

        string connString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
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
            DataTable dt = new DataTable();

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
    }

    
}
