using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient; 

namespace CC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_doc form = new Tipo_doc();
            form.ShowDialog();
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {
            lblNombre.Text = Usuario.Nombre;
            if (Usuario.Admin == "1")
            {
                lblAdmin.Text = "Administrador";
            }
            else
            {
                lblAdmin.Text = "Usuario Normal";
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes form = new Clientes();
            form.ShowDialog();
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
         
        {
          
        }

        private void balancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblAdmin.Text == "Usuario Normal")
            {

                MessageBox.Show("No posee acceso a Balances");
            }
            else
            {
                CC.Balances form = new CC.Balances();
                form.ShowDialog();
            }
        }
    }
    }
