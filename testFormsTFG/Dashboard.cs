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


        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.labelUser.Text = user;
        }

        private void btnPersonal_Load(object sender, EventArgs e)
        {
            this.btnPersonal.BotonAplicacionClick += BtnPersonal_BotonAplicacionClick;
        }

        private void BtnPersonal_BotonAplicacionClick()
        {
            ControlPersonal.ControlPersonal CP = new ControlPersonal.ControlPersonal();
            CP.Show();
        }

        private void btnRecMP_Load(object sender, EventArgs e)
        {
            this.btnRecMP.BotonAplicacionClick += BtnRecMP_BotonAplicacionClick;
        }

        private void BtnRecMP_BotonAplicacionClick()
        {
            MateriaPrima.MateriaPrima MP = new MateriaPrima.MateriaPrima();
            MP.Show();
        }

        private void btnOps_Load(object sender, EventArgs e)
        {
            this.btnOps.BotonAplicacionClick += BtnOps_BotonAplicacionClick;
        }

        private void BtnOps_BotonAplicacionClick()
        {
            FichajeOperaciones.FichajeOperaciones FO = new FichajeOperaciones.FichajeOperaciones();
            FO.Show();
        }

        private void btnArt_Load(object sender, EventArgs e)
        {
            this.btnArt.BotonAplicacionClick += BtnArt_BotonAplicacionClick;
        }

        private void BtnArt_BotonAplicacionClick()
        {
            Articulos.Articulos ART = new Articulos.Articulos();
            ART.Show();
        }

        private void btnProys_Load(object sender, EventArgs e)
        {
            this.btnProys.BotonAplicacionClick += BtnProys_BotonAplicacionClick;
        }

        private void BtnProys_BotonAplicacionClick()
        {
            GestionProyectos.GestionProyectos GP = new GestionProyectos.GestionProyectos();
            GP.Show();
        }

        private void btnPaqs_Load(object sender, EventArgs e)
        {
            this.btnPaqs.BotonAplicacionClick += BtnPaqs_BotonAplicacionClick;
        }

        private void BtnPaqs_BotonAplicacionClick()
        {
            PaquetesAlmacen.PaquetesAlmacen PAQ = new PaquetesAlmacen.PaquetesAlmacen();
            PAQ.Show();
        }
    }
}
