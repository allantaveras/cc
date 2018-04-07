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
using Dapper;

namespace CC
{
    public partial class Clientes : Form
    {
        SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=cc;Data Source=DESKTOP-6QJHF2G");
        int id_cliente = 0;
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)


        {
            try
            {
                fillDataGridView();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
        void Clear()
        {
            txtEstado.Text = txtEstado.Text = txtNombre.Text = nmLimite.Text = "";
            id_cliente = 0;
            btnguardar.Text = "Guardar";
            btnBorrar.Enabled = false;
        }
        class CL
        {
            public int id_cliente { get; set; }
            public string Nombre { get; set; }
            public int Lim_Credito  { get; set; }
            public string Estado { get; set; }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                DynamicParameters param = new DynamicParameters();

                param.Add("@id_cliente", id_cliente);
                param.Add("@Nombre", txtNombre.Text.Trim());
                param.Add("@Cedula", txtCedula.Text.Trim());
                param.Add("@Lim_Credito", nmLimite.Text.Trim());
                param.Add("@Estado", txtEstado.Text.Trim());
                sqlcon.Execute("ClientesAddOrEdit", param, commandType: CommandType.StoredProcedure);
                if (id_cliente == 0)
                    MessageBox.Show("Guardado Exitosamente");
                else
                    MessageBox.Show("Actualizado Exitosamente");
                fillDataGridView();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void fillDataGridView()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Searchtext", txtBuscar.Text.Trim());

            List<CL> list = sqlcon.Query<CL>("ClientesViewAllOrSearch", param, commandType: CommandType.StoredProcedure).ToList<CL>();
            dgvClientes.DataSource = list;
            dgvClientes.Columns[0].Visible = false;
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentRow.Index != -1)
                {
                    id_cliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value.ToString());
                    txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                    txtCedula.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                    nmLimite.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                    btnBorrar.Enabled = true;
                    btnguardar.Text = "Editar";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_cliente", id_cliente);
                sqlcon.Execute("ClientesDelete", param, commandType: CommandType.StoredProcedure);
                Clear();
                fillDataGridView();
                MessageBox.Show("Borrado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
