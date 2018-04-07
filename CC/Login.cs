using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;


namespace CC
{
   
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=cc;Data Source=DESKTOP-6QJHF2G");
            string query = "Select * from Usuarios Where Usuario = '" + txtUsuario.Text.Trim() + "' and Clave = '" + txtClave.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
              
                Usuario.Admin = dtbl.Rows[0][columnName: "Admin"].ToString();
                Usuario.Nombre = dtbl.Rows[0][columnName: "Nombre"].ToString();

                CC.Menu f = new CC.Menu();
                
               this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Clave incorrecto(s)");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
