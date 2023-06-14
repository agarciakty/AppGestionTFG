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


        }

        private void cargarPaquetesTimeSpan()
        {
            tablaPaqs = fbd.getPaquetes(this.dateTimePicker1.Value, this.dateTimePicker2.Value);

            this.dgvPaquetes.DataSource = tablaPaqs;
        }
    }
}
