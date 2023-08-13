using AppGestionTFG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testFormsTFG.FichajeOperaciones
{
    public partial class FichajeOperaciones : Form
    {
        public FichajeOperaciones()
        {
            InitializeComponent();
        }

        DataTable datosProy = new DataTable();
        DataTable datosOpe = new DataTable();
        FuncionesBD fbd = new FuncionesBD();

        private void FichajeOperaciones_Load(object sender, EventArgs e)
        {
            this.cbProy.Items.Clear();

            List<string> atb = new List<string>();
            atb.Add("*");

            datosProy = fbd.getSelect("tfgdb.dbo.PROYECTOS", atb, null, "ID_PROY");
            this.cbProy.Items.Add("TODOS");
            foreach (DataRow row in datosProy.Rows)
            {
                this.cbProy.Items.Add(row[0].ToString() + "#" + row[1].ToString());
            }
            this.cbProy.SelectedIndex = 0;

        }

        private void cargarOps(string dniOperario)
        {
            List<string> atb = new List<string>();
            atb.Add("PROYECTO");
            atb.Add("PIEZA");
            atb.Add("FECHA_CRE AS [FECHA]");
            atb.Add("MP_BASE as [MATERIA PRIMA]");
            atb.Add("ESTADO");
            atb.Add("NOMBRE_OPERACION as [OPERACIÓN]");
            atb.Add("DNI_EMP_ASIGNADO");
            atb.Add("OPERACION AS N_OPE");
            atb.Add("PARCELA_MATERIAL");


            List<string> cond = new List<string>();
            cond.Add("ESTADO NOT LIKE 'FINALIZADO'");
            cond.Add("DNI_EMP_ASIGNADO LIKE '" + dniOperario + "'");

            datosOpe = fbd.getSelect("tfgdb.dbo.OPERACIONES oper left join tfgdb.dbo.TIPOS_OPER tope ON tope.ID_OPERACION = oper.OPERACION", atb, cond, "FECHA_CRE ASC");

            this.dgvOps.DataSource = datosOpe;

            foreach (DataGridViewRow row in dgvOps.Rows)
            {
                if (row.Cells["ESTADO"].Value.ToString() == "PENDIENTE")
                {
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cargarOps(this.tbInvOper.Text);

                List<string> atb = new List<string>();
                atb.Add("CONCAT( NOMBRE, ' ', APELLIDO1, ' ', APELLIDO2)");

                List<string> cond = new List<string>();
                cond.Add("DNI LIKE '" + this.tbInvOper.Text + "'");

                if (tbInvOper.Text != "")
                {
                    this.tbOperario.Text = fbd.getSelect("rrhh_db.dbo.PERSONAL", atb, cond, null).Rows[0][0].ToString();

                    this.dgvOps.Columns["PROYECTO"].Visible = false;
                    this.dgvOps.Columns["DNI_EMP_ASIGNADO"].Visible = false;
                    this.dgvOps.Columns["N_OPE"].Visible = false;
                    this.dgvOps.Columns["PARCELA_MATERIAL"].Visible = false;
                }

            }
        }

        private void cbProy_SelectedIndexChanged(object sender, EventArgs e)
        {

            string textofiltro = "";
            if (cbProy.SelectedItem.ToString() != "TODOS")
            {
                textofiltro = "(PROYECTO LIKE '" + ((int)datosProy.Rows[cbProy.SelectedIndex]["ID_PROY"] - 1).ToString() + "') ";

            }

            datosOpe.DefaultView.RowFilter = textofiltro;
        }

        private void btnIni_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.dgvOps.SelectedRows)
            {
                if (row.Cells["ESTADO"].Value.ToString() == "PENDIENTE")
                {
                    List<string> atb = new List<string>();
                    atb.Add("FECHA_INI = GETDATE()");
                    atb.Add("ESTADO = 'EN PROCESO'");

                    List<string> cond = new List<string>();
                    cond.Add("DNI_EMP_ASIGNADO LIKE '" + this.tbInvOper.Text + "'");
                    cond.Add("PROYECTO LIKE '" + row.Cells["PROYECTO"].Value.ToString() + "'");
                    cond.Add("PIEZA LIKE '" + row.Cells["PIEZA"].Value.ToString() + "'");
                    cond.Add("OPERACION LIKE '" + row.Cells["N_OPE"].Value.ToString() + "'");

                    fbd.actualizar("tfgdb.dbo.OPERACIONES", atb, cond, null);

                    MessageBox.Show("Operación de " + row.Cells[5].Value.ToString() + " iniciada para pieza " + row.Cells["PIEZA"].Value.ToString(), "ATENCIÓN");

                    cargarOps(this.tbInvOper.Text);

                }
                else
                {
                    MessageBox.Show("La operación seleccionada ya ha sido iniciada.", "ATENCIÓN");
                }
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvOps.SelectedRows)
            {
                if (row.Cells["ESTADO"].Value.ToString() == "EN PROCESO")
                {

                    List<string> atb = new List<string>();
                    atb.Add("FECHA_FAB = GETDATE()");
                    atb.Add("ESTADO = 'FINALIZADO'");

                    List<string> cond = new List<string>();
                    cond.Add("DNI_EMP_ASIGNADO LIKE '" + this.tbInvOper.Text + "'");
                    cond.Add("PROYECTO LIKE '" + row.Cells["PROYECTO"].Value.ToString() + "'");
                    cond.Add("PIEZA LIKE '" + row.Cells["PIEZA"].Value.ToString() + "'");
                    cond.Add("OPERACION LIKE '" + row.Cells["N_OPE"].Value.ToString() + "'");

                    fbd.actualizar("tfgdb.dbo.OPERACIONES", atb, cond, null);


                    MessageBox.Show("Operación de " + row.Cells[5].Value.ToString() + " finalizada para pieza " + row.Cells["PIEZA"].Value.ToString(), "ATENCIÓN");

                    cargarOps(this.tbInvOper.Text);

                }
                else
                {
                    MessageBox.Show("La operación seleccionada no ha sido iniciada.", "ATENCIÓN");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvOps.SelectedRows)
            {
                if (row.Cells["ESTADO"].Value.ToString() == "EN PROCESO")
                {

                    List<string> atb = new List<string>();
                    atb.Add("FECHA_INI = NULL");
                    atb.Add("ESTADO = 'PENDIENTE'");

                    List<string> cond = new List<string>();
                    cond.Add("DNI_EMP_ASIGNADO LIKE '" + this.tbInvOper.Text + "'");
                    cond.Add("PROYECTO LIKE '" + row.Cells["PROYECTO"].Value.ToString() + "'");
                    cond.Add("PIEZA LIKE '" + row.Cells["PIEZA"].Value.ToString() + "'");
                    cond.Add("OPERACION LIKE '" + row.Cells["N_OPE"].Value.ToString() + "'");

                    fbd.actualizar("tfgdb.dbo.OPERACIONES", atb, cond, null);


                    MessageBox.Show("Operación cancelada", "ATENCIÓN");

                    cargarOps(this.tbInvOper.Text);

                }
                else
                {
                    MessageBox.Show("La operación seleccionada no ha sido iniciada.", "ATENCIÓN");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;

            foreach (DataGridViewRow row in this.dgvOps.SelectedRows)
            {
                
            }
        }

        private void btnCerrarPanel3_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
        }

        private void dgvOps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOps_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvOps.SelectedRows)
            {
                if (string.IsNullOrEmpty(row.Cells["PARCELA_MATERIAL"].Value.ToString()))
                {
                    this.labelProy.Text = row.Cells["PROYECTO"].Value.ToString();

                    this.labelParcelasPieza.Text = "PARCELAS CON STOCK DE " + row.Cells["MATERIA PRIMA"].Value.ToString();
                    List<string> atb = new List<string>();
                    atb.Add("PAQUETE");
                    atb.Add("CANTIDAD_REAL AS [CANTIDAD]");
                    atb.Add("(SELECT TOP (1) PARCELA FROM tfgdb.dbo.PAQUETES_ENTRADA_ALMACEN pea WHERE pea.N_PAQUETE = pmp.PAQUETE order by FECHA_RECP desc ) as PARCELA");

                    List<string> cond = new List<string>();
                    cond.Add("ARTICULO = '" + row.Cells["MATERIA PRIMA"].Value.ToString() + "'");

                    this.dgvParcelas.DataSource = fbd.getSelect("tfgdb.dbo.PAQUETES_MP pmp", atb, cond, "CANTIDAD_REAL DESC");

                    this.labelParcela.Text = this.dgvParcelas.Rows[0].Cells[2].Value.ToString();
                }
                else
                {
                    this.labelParcela.Text = row.Cells["PARCELA_MATERIAL"].Value.ToString();
                }
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvOps.SelectedRows)
            {

                List<string> atb = new List<string>();
                atb.Add("PARCELA_MATERIAL = '" + dgvParcelas.SelectedRows[0].Cells[2].Value.ToString() + "'");

                List<string> cond = new List<string>();
                cond.Add("DNI_EMP_ASIGNADO LIKE '" + this.tbInvOper.Text + "'");
                cond.Add("PROYECTO LIKE '" + row.Cells["PROYECTO"].Value.ToString() + "'");
                cond.Add("PIEZA LIKE '" + row.Cells["PIEZA"].Value.ToString() + "'");
                cond.Add("OPERACION LIKE '" + row.Cells["N_OPE"].Value.ToString() + "'");

                fbd.actualizar("tfgdb.dbo.OPERACIONES", atb, cond, null);

                this.labelParcela.Text = dgvParcelas.SelectedRows[0].Cells[2].Value.ToString();

                cargarOps(this.tbInvOper.Text);

            }
        }
    }
}
