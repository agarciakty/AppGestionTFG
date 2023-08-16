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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace testFormsTFG.ControlPersonal
{
    public partial class ControlPersonal : Form
    {

        FuncionesBD fbd = new FuncionesBD();
        DataTable dt;


        public ControlPersonal()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void ControlPersonal_Load(object sender, EventArgs e)
        {
            actualizarDgv();
            this.dgvPersonal.DefaultCellStyle.Font = new Font("Tahoma", 15);
            this.dgvPersonal.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15, FontStyle.Bold);
            foreach (DataRow row in fbd.obtenerPuestos().Rows)
            {
                cbPuesto.Items.Add(row[0].ToString());
            }

            comboBox1.Items.Add("TODOS");
            foreach (DataRow row in fbd.obtenerDepartamentos().Rows)
            {
                cbDept.Items.Add(row[0].ToString());
                comboBox1.Items.Add(row[0].ToString());
            }

            comboBox1.SelectedIndex = 0;
            

        }

        private void actualizarDgv()
        {
            dt = fbd.obtenerPersonal();
            dgvPersonal.DataSource = dt;
        }

        private void btnRegistrarPersonal_Click(object sender, EventArgs e)
        {
            labelPanelAltaModif.Text = "ALTA DE EMPLEADO";

            tbNombre.Enabled = true;
            tbAp1.Enabled = true;
            tbAp2.Enabled = true;
            tbDNI.Enabled = true;
            cbDept.Enabled = true;
            cbPuesto.Enabled = true;

            tbNombre.Clear();
            tbAp1.Clear();
            tbAp2.Clear();
            tbDNI.Clear();

            cbDept.SelectedIndex = 0;
            cbPuesto.SelectedIndex = 0;
            btnModifDatos.Visible = false;
            btnConfirmarAlta.Visible = true;

            panel1.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnConfirmarAlta_Click(object sender, EventArgs e)
        {
            if (labelPanelAltaModif.Text == "ALTA DE EMPLEADO")
            {
                fbd.insertarPersonal(tbNombre.Text, tbAp1.Text, tbAp2.Text, tbDNI.Text, fbd.getPuestoID(cbPuesto.Text), fbd.getDptoID(cbDept.Text));
                MessageBox.Show("Alta de empleado correcta", "ALTA FINALIZADA");
                panel1.Visible = false;
            }
            else
            {
                fbd.actualizarPersonal(tbNombre.Text, tbAp1.Text, tbAp2.Text, tbDNI.Text, fbd.getPuestoID(cbPuesto.Text), fbd.getDptoID(cbDept.Text), labelOcultaID.Text);
                MessageBox.Show("Datos actualizados", "ACTUALIZACIÓN CORRECTA");
            }
            actualizarDgv();
           
        }

        private void dgvPersonal_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgvPersonal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            labelPanelAltaModif.Text = "DATOS DE EMPLEADO";
            labelOcultaID.Text = dgvPersonal.SelectedRows[0].Cells[0].Value.ToString();

            DataTable dt = new DataTable();

            dt = fbd.obtenerPersonaID(dgvPersonal.SelectedRows[0].Cells["ID_PERSONAL"].Value.ToString());

            tbNombre.Text = dt.Rows[0]["NOMBRE"].ToString();
            tbAp1.Text = dt.Rows[0]["APELLIDO1"].ToString();
            tbAp2.Text = dt.Rows[0]["APELLIDO2"].ToString();
            tbDNI.Text = dt.Rows[0]["DNI"].ToString();
            cbDept.SelectedIndex = cbDept.FindStringExact(dt.Rows[0]["DEPARTAMENTO"].ToString());
            cbPuesto.SelectedIndex = cbPuesto.FindStringExact(dt.Rows[0]["PUESTO"].ToString());

            tbNombre.Enabled = false;
            tbAp1.Enabled = false;
            tbAp2.Enabled = false;
            tbDNI.Enabled = false;
            cbDept.Enabled = false;
            cbPuesto.Enabled = false;

            btnModifDatos.Visible = true;
            btnConfirmarAlta.Visible = false;    

            panel1.Visible = true;

        }

        private void btnModifDatos_Click(object sender, EventArgs e)
        {
            tbNombre.Enabled = true;
            tbAp1.Enabled = true;
            tbAp2.Enabled = true;
            tbDNI.Enabled = true;
            cbDept.Enabled = true;
            cbPuesto.Enabled = true;

            btnConfirmarAlta.Visible = true;
        }

        private void filtrar()
        {
            string textofiltro = "";
            textofiltro = "(NOMBRE LIKE '%" + textBox1.Text + "%') ";

            if (comboBox1.SelectedIndex != 0)
            {
                textofiltro += " AND (DEPARTAMENTO LIKE '%" + comboBox1.Text + "%')";
            }

            dt.DefaultView.RowFilter = textofiltro;

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Se van a dar de baja a los empleados seleccionados, ¿Continuar?",
                      "ATENCIÓN", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:

                        foreach (DataGridViewRow row in dgvPersonal.SelectedRows)
                        {
                            List<string> atb = new List<string>();
                            atb.Add("F_BAJA = GETDATE()");

                            List<string> cond = new List<string>();
                            cond.Add("DNI = '" + row.Cells["DNI"].Value.ToString() + "'");

                            fbd.actualizar("rrhh_db.dbo.PERSONAL", atb, cond, null);

                            MessageBox.Show("Se ha dado de baja al empleado con ID " + row.Cells[0].Value.ToString(), "BAJA PROCESADA");
                        }

                        break;
                    case DialogResult.No:
                        break;
                }
                


            }
            else
            {
                MessageBox.Show("Seleccione a un empleado", "NO HA SELECCIONADO PERSONAL");
            }
        }
    }
}
