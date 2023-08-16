using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testFormsTFG;

namespace AppGestionTFG
{
    public partial class Principal : Form
    {

        FuncionesBD fbd = new FuncionesBD();
        public string userGral = "";
        SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True");
        public DataTable permisos = new DataTable();

        public Principal()
        {
            InitializeComponent();
            textBoxPass.UseSystemPasswordChar = true;

        }

        private void Principal_KeyDown1(object sender, KeyEventArgs e)
        {
            //throw new NotImplementedException();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            

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
            SelectData(this.textBoxUser.Text, this.textBoxPass.Text);
        }

        private static string HashString(string passwordString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(passwordString))
                sb.Append(b.ToString("X3"));
            return sb.ToString();
        }

        private static byte[] GetHash(string passwordString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordString));
        }

        private string SelectData(string user, string pass)
        {
            try
            {
                string priv = "";

                conn.Open();
                DataTable datos = new DataTable();
                
                string passSHA = HashString(pass);


                List<string> atb = new List<string>();
                atb.Add("*");

                List<string> cond = new List<string>();
                cond.Add("pass = '" + passSHA + "'");
                cond.Add("usuario = '" + user + "'");

                datos = fbd.getSelect("tfgdb.dbo.USUARIOS_PRIV", atb, cond, null);

                if (datos.Rows.Count != 0)
                {
                    labelFalloPassword.Text = "";
                    labelFalloPassword.Visible = false;

                    List<string> atb2 = new List<string>();
                    atb2.Add("APP");

                    List<string> cond2 = new List<string>();
                    cond2.Add("usuario = '" + user + "'");
                    permisos = fbd.getSelect("tfgdb.dbo.PERMISOS_APPS", atb2, cond2, null);


                    userGral = this.textBoxUser.Text;
                    this.Close();
                }
                else
                {
                    labelFalloPassword.Text = "Usuario o contraseña incorrectos";
                    labelFalloPassword.Visible = true;
                }

                return priv;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
