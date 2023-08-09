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
            atb.Add("*");

            List<string> cond = new List<string>();
            cond.Add("ESTADO NOT LIKE 'FINALIZADA'");
            cond.Add("DNI_EMP_ASIGNADO LIKE '" + dniOperario + "'");

            datosOpe = fbd.getSelect("tfgdb.dbo.OPERACIONES", atb, cond, "FECHA_CRE ASC");

            this.dgvOps.DataSource = datosOpe;
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

                this.tbOperario.Text = fbd.getSelect("rrhh_db.dbo.PERSONAL", atb, cond, null).Rows[0][0].ToString();
            }
        }

        private void cbProy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
