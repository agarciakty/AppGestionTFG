using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testFormsTFG;

namespace AppGestionTFG
{
    public partial class Principal : Form
    {

        FuncionesBD dbu;
        public string user = "";

        public Principal()
        {
            InitializeComponent();
            textBoxPass.UseSystemPasswordChar = true;
            dbu = new FuncionesBD();

        }

        private void Principal_KeyDown1(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(connString);

            conn.Open();

            string strsql = "SELECT nombre FROM tfgdb.dbo.table_test1 where test = '" + this.textBoxUser.Text + "'";
            SqlCommand cmd = new SqlCommand(strsql, conn);

            DataTable table = new DataTable();

            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    strsql, conn);
                adapter.Fill(table);
            }

            this.label1.Text = table.Rows[0][0].ToString();

            conn.Close();


        }

        private void Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOcultarPass_Click(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = true;
            btnOcultarPass.Visible = false;
        }

        private void btnVerPass_Click(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = false;
            btnOcultarPass.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string priv = "";
            if (dbu.obtenerPrivilegiosUsuario(textBoxUser.Text, textBoxPass.Text) == "DENIED")
            {
                labelFalloPassword.Text = "Usuario o contraseña incorrectos";
                labelFalloPassword.Visible = true;
            }
            else
            {
                labelFalloPassword.Text = "";
                labelFalloPassword.Visible = false;

                user = this.textBoxUser.Text;
                this.Close();
            }
        }
    }
}
