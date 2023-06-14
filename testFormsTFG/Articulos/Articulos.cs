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
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace testFormsTFG.Articulos
{
    public partial class Articulos : Form
    {



        System.Data.DataTable articulos = new System.Data.DataTable();
        FuncionesBD fbd = new FuncionesBD();
        bool nuevo = false;

        System.Data.DataTable categos = new System.Data.DataTable();
        System.Data.DataTable provs = new System.Data.DataTable();

        int IDmodif = 0;

        public Articulos()
        {
            InitializeComponent();
        }

        private void Articulos_Load(object sender, EventArgs e)
        {

            recargar();
            categos = fbd.getCatego();

            foreach(DataRow row in categos.Rows)
            {
                this.cbCat.Items.Add(row["CATEGORIA"].ToString());
                this.comboFiltroCatego.Items.Add(row["CATEGORIA"].ToString());

            }
            this.cbCat.SelectedIndex = 0;

            provs = fbd.getProvs();
            foreach (DataRow row in provs.Rows)
            {
                this.comboProv.Items.Add(row["NOMBRE"].ToString());
                this.comboFiltroProv.Items.Add(row["NOMBRE"].ToString());
            }

            this.comboProv.SelectedIndex = 0;
            this.comboFiltroProv.SelectedText = "TODOS";
            this.comboFiltroCatego.SelectedText = "TODOS";
        }

        private void recargar()
        {
            articulos = fbd.getArticulos();
            this.dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 15);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 15, FontStyle.Bold);

            this.dataGridView1.DataSource = articulos;

            this.dataGridView1.Columns["ID"].Visible = false;

            this.cbCat.Items.Clear();
            this.comboProv.Items.Clear();

            this.comboFiltroCatego.Items.Clear();
            this.comboFiltroProv.Items.Clear();

            this.comboFiltroCatego.Items.Add("TODOS");
            this.comboFiltroProv.Items.Add("TODOS");



        }

        private void exportar()
        {
            DialogResult dialogResult = MessageBox.Show("¿Continuar la exportación a Excel?", "EXPORTACÍÓN AUTOMÁTICA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                copiarPortapapeles();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
            else if (dialogResult == DialogResult.No)
            {
                //nada
            }

            
        }

        private void copiarPortapapeles()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.tbCodigo.Clear();
            this.tbDenomi.Clear();
            this.nupStock.Value = 0;
            nuevo = true;

            this.panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {
                if (fbd.insertArticulo(this.tbCodigo.Text, this.tbDenomi.Text, categos.Rows[this.cbCat.SelectedIndex][1].ToString(), provs.Rows[this.comboProv.SelectedIndex][1].ToString(), this.nupStock.Value.ToString()) > 0)
                MessageBox.Show("Se ha insertado correctamente el artículo", "INSERTADO");
                nuevo = false;
            }
            else
            {
                fbd.updateArticulo(this.tbCodigo.Text, this.tbDenomi.Text, categos.Rows[this.cbCat.SelectedIndex][1].ToString(), provs.Rows[this.comboProv.SelectedIndex][1].ToString(), this.nupStock.Value.ToString(), IDmodif);
                MessageBox.Show("Se ha actualizado correctamente el artículo con ID " + IDmodif, "ACTUALIZADO");
            }

            this.panel1.Visible=false;
            recargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {

                DialogResult result = MessageBox.Show("Se van a eliminar " + this.dataGridView1.SelectedRows.Count.ToString() + " artículo(s), ¿Continuar?", "ATENCIÓN", MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                    {
                        fbd.eliminarArticulo(row.Cells["CODIGO"].Value.ToString());
                    }
                }

                //MessageBox.Show("Seleccione un ARTÍCULO", "ATENCIÓN");
                recargar();
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1 )
            {


                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    this.tbCodigo.Text = row.Cells["CODIGO"].Value.ToString();
                    this.tbDenomi.Text = row.Cells["DENOMINACION"].Value.ToString();
                    this.cbCat.SelectedItem = row.Cells["CATEGORIA"].Value.ToString();
                    this.comboProv.SelectedItem = row.Cells["PROVEEDOR"].Value.ToString();

                    string stockS = row.Cells["STOCK"].Value.ToString();
                    int stock = 0;

                    Int32.TryParse(stockS, out stock);

                    this.nupStock.Value = stock;

                    IDmodif = Convert.ToInt32( row.Cells["ID"].Value.ToString() );

                    this.panel1.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Seleccione únicamente un ARTÍCULO", "ATENCIÓN");
            }
        }

        private void filtrar ()
        {
            string textofiltro = "";
            textofiltro = "(CODIGO LIKE '%" + tbSearch.Text + "%' OR DENOMINACION LIKE '%" + tbSearch.Text + "%' OR CONVERT([ID], System.String) LIKE '%" + tbSearch.Text + "%') ";

            if (comboFiltroCatego.SelectedItem != null && comboFiltroCatego.SelectedItem.ToString() != "TODOS")
            {
                textofiltro += " AND CATEGORIA LIKE '%" + comboFiltroCatego.SelectedItem.ToString() + "%'";
            }

            if (comboFiltroProv.SelectedItem != null && comboFiltroProv.SelectedItem.ToString() != "TODOS" )
            {
                textofiltro += " AND PROVEEDOR LIKE '%" + comboFiltroProv.SelectedItem.ToString() + "%'";
            }

            articulos.DefaultView.RowFilter = textofiltro;
        }


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            exportar();
        }

        private void comboFiltroCatego_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void comboFiltroProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }
    }
}
