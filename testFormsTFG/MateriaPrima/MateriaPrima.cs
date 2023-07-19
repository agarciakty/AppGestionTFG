using AppGestionTFG;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testFormsTFG.Articulos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testFormsTFG.MateriaPrima
{
    public partial class MateriaPrima : Form
    {
        DataTable tablaPaqs = new DataTable();
        FuncionesBD fbd = new FuncionesBD();

        bool editar = false;
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
            this.panelMP.Visible = false;
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
            editar = false;

            this.panelMP.Visible = true;
            this.cbCodigos.ResetText();


            this.labelDenom.Text = "-";
            this.labelCat.Text = "-";
            this.labelProv.Text = "-";
            this.nupStock.Value = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                fbd.añadirMPPaquete(this.labelPaq.Text, this.cbCodigos.SelectedItem.ToString(), (int)this.nupStock.Value);
            }
            else
            {
                fbd.editarMPPaquete(this.labelPaq.Text, this.cbCodigos.SelectedItem.ToString(), (int)this.nupStock.Value);
            }
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPaquetes.SelectedRows.Count > 0)
            {

                DialogResult result = MessageBox.Show("Se van a eliminar " + this.dgvMP.SelectedRows.Count.ToString() + " artículo(s) del paquete " + this.labelPaq.Text + ", ¿Continuar?", "ATENCIÓN", MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in this.dgvMP.SelectedRows)
                    {
                        fbd.eliminarMPPaquete(row.Cells["ARTICULO"].Value.ToString(), this.labelPaq.Text);
                    }
                }

                //MessageBox.Show("Seleccione un ARTÍCULO", "ATENCIÓN");
                selectPaquete(this.labelPaq.Text);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvMP.SelectedRows.Count == 1)
            {
                editar = true;

                this.panelMP.Visible = true;


                this.cbCodigos.SelectedIndex = cbCodigos.FindStringExact(this.dgvMP.SelectedRows[0].Cells[1].Value.ToString());
                this.nupStock.Value = Convert.ToUInt32(this.dgvMP.SelectedRows[0].Cells[2].Value.ToString());
            }
            else
            {
                MessageBox.Show("Seleccione un sólo artículo", "ATENCIÓN");
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    //var fileStream = openFileDialog.OpenFile();

                    //using (StreamReader reader = new StreamReader(fileStream))
                    //{
                    //    fileContent = reader.ReadToEnd();
                    //}

                    string[] filasDatos = File.ReadAllLines(filePath);

                    DataTable import = new DataTable();
                    string[] valores = null;
                    DataRow fila = import.NewRow();

                    if (filasDatos.Length > 0)
                    {
                        //paquete;articulo;cantidad

                        //Esto procesa el header
                        /*
                        foreach (string columnName in filasDatos[0].Split(';'))
                        {
                            import.Columns.Add(columnName);
                        }
                        */

                        int columna = 0;

                        string paq = "";
                        string articulo = "";
                        string cant = "";

                        for (int i = 0; i < filasDatos.Length; i++)
                        {
                            columna = 0;
                            foreach (string valor in filasDatos[i].Split(';'))
                            {
                                switch (columna)
                                {
                                    case 0:
                                        paq = valor;
                                        break;
                                    case 1:
                                        articulo = valor;
                                        break;
                                    default:
                                        cant = valor;
                                        break;
                                }
                                columna++;
                            }
                            fbd.añadirMPPaquete(paq, articulo, Convert.ToInt32(cant));
                        }

                    }

                    MessageBox.Show("Importación completa");

                    if (this.labelPaq.Text != "-")
                    {
                        selectPaquete(this.labelPaq.Text);
                    }
                }
            }

            
        }
    }
}
