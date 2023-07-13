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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testFormsTFG.MateriaPrima
{
    public partial class MateriaPrima : Form
    {
        DataTable tablaPaqs = new DataTable();
        FuncionesBD fbd = new FuncionesBD();
        public MateriaPrima()
        {
            InitializeComponent();
        }

        private void MateriaPrima_Load(object sender, EventArgs e)
        {
            this.dateTimePicker2.Value = DateTime.Now;
            this.dateTimePicker1.Value = DateTime.Now.AddMonths(-1);
            cargarPaquetesTimeSpan();
            this.dgvPaquetes.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 15);
            this.dgvPaquetes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 15, FontStyle.Bold);

            this.dgvMP.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 15);
            this.dgvMP.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 15, FontStyle.Bold);

            foreach(DataRow row in fbd.getArticulos().Rows)
            {
                this.cbCodigos.Items.Add(row["CODIGO"].ToString());
            }


        }

        private void cargarPaquetesTimeSpan()
        {
            tablaPaqs = fbd.getPaquetes(this.dateTimePicker1.Value, this.dateTimePicker2.Value);

            this.dgvPaquetes.DataSource = tablaPaqs;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cargarPaquetesTimeSpan();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            cargarPaquetesTimeSpan();
        }

        private void selectPaquete(string paquete)
        {
            this.dgvMP.DataSource = fbd.getMPPaquetes(paquete);
            this.labelPaq.Text = paquete;
            this.labelEstado.Text = fbd.getEstadoPaquete(paquete);
            this.labelUbic.Text = this.dgvPaquetes.SelectedRows[0].Cells[1].Value.ToString();

            this.btnNuevo.Visible = true;
            this.btnEliminar.Visible = true;
            this.btnEditar.Visible = true;

            this.label8.Visible = true;
            this.label9.Visible = true;
            this.label10.Visible = true;

            if (this.labelEstado.Text != "CONFIRMADO")
            {
                this.btnNuevo.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnEditar.Enabled = true;
            }
            else
            {
                this.btnNuevo.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnEditar.Enabled = false;
            }
        }

        private void btnContenido_Click(object sender, EventArgs e)
        {
            selectPaquete(this.dgvPaquetes.SelectedRows[0].Cells[0].Value.ToString());

        }

        private void tbSearchPaq_TextChanged(object sender, EventArgs e)
        {
            string textofiltro = "";
            textofiltro = "(PAQUETE LIKE '%" + tbSearchPaq.Text + "%') ";

            tablaPaqs.DefaultView.RowFilter = textofiltro;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.panelMP.Visible = true;
            this.cbCodigos.ResetText();


            this.labelDenom.Text = "-";
            this.labelCat.Text = "-";
            this.labelProv.Text = "-";
            this.nupStock.Value = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            fbd.añadirMPPaquete(this.labelPaq.Text, this.cbCodigos.SelectedItem.ToString(), (int)this.nupStock.Value);
            selectPaquete(this.labelPaq.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.panelMP.Visible=false;
        }

        private void cbCodigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable info = fbd.getInfoMP(this.cbCodigos.SelectedItem.ToString());

            this.labelDenom.Text = info.Rows[0]["DENOMINACION"].ToString();
            this.labelCat.Text = info.Rows[0]["CATEGORIA"].ToString();
            this.labelProv.Text = info.Rows[0]["NOMBRE"].ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            fbd.confirmarPaqueteMP(this.labelPaq.Text);
            selectPaquete(this.labelPaq.Text);
            MessageBox.Show("Se ha confirmado correctamente el contenido del paquete con ID " + this.labelPaq.Text, "PAQUETE CONFIRMADO");
        }
    }
}
