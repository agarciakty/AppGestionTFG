using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testFormsTFG.ControlPersonal;

namespace testFormsTFG
{
    public partial class Dashboard : Form
    {

        public string user;
        public DataTable permisos = new DataTable();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCPersonal_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulos.Articulos articulos = new Articulos.Articulos();
            articulos.Show();
        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            MateriaPrima.MateriaPrima MP = new MateriaPrima.MateriaPrima();
            MP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaquetesAlmacen.PaquetesAlmacen PA = new PaquetesAlmacen.PaquetesAlmacen();
            PA.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestionProyectos.GestionProyectos GP = new GestionProyectos.GestionProyectos();
            GP.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FichajeOperaciones.FichajeOperaciones FO = new FichajeOperaciones.FichajeOperaciones();
            FO.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.labelUser.Text = user;
        }

    }
}
