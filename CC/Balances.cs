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
    public partial class Balances : Form
    {
        SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=cc;Data Source=DESKTOP-6QJHF2G");
        int id_cliente = 0;
        public Balances()
        {
            InitializeComponent();
        }
        void Clear()
        {
            txtFecha.Text = txtMonto.Text = txtMonto.Text = "";
            id_cliente = 0;
            btnguardar.Text = "Guardar";
            btnBorrar.Enabled = false;
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                DynamicParameters param = new DynamicParameters();

                param.Add("@id_cliente", id_cliente);
                param.Add("@Fecha_Corte", txtFecha.Text.Trim());
                param.Add("@antiguedad_prom_saldos", txtPromedio.Text.Trim());
                param.Add("@Monto", txtMonto.Text.Trim());
                sqlcon.Execute("BalancesAddOrEdit", param, commandType: CommandType.StoredProcedure);
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
        class BL
        {
            public int id_clientes { get; set; }
            public string Fecha_corte { get; set; }
            public string antiguedad_prom_saldos { get; set; }
            public string Monto { get; set; }

        }
        void fillDataGridView()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Searchtext", txtBuscar.Text.Trim());

            List<BL> list = sqlcon.Query<BL>("tipo_docViewAllOrSearch", param, commandType: CommandType.StoredProcedure).ToList<BL>();
            dgvBalances.DataSource = list;
            dgvBalances.Columns[0].Visible = false;
        }

        private void Balances_Load(object sender, EventArgs e)
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

        private void dgvBalances_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvBalances.CurrentRow.Index != -1)
                {
                    id_cliente = Convert.ToInt32(dgvBalances.CurrentRow.Cells[0].Value.ToString());
                    txtFecha.Text = dgvBalances.CurrentRow.Cells[1].Value.ToString();
                    txtPromedio.Text = dgvBalances.CurrentRow.Cells[2].Value.ToString();
                    txtMonto.Text = dgvBalances.CurrentRow.Cells[3].Value.ToString();
                    btnBorrar.Enabled = true;
                    btnguardar.Text = "Editar";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id", id_cliente);
                sqlcon.Execute("BalancesDelete", param, commandType: CommandType.StoredProcedure);
                Clear();
                fillDataGridView();
                MessageBox.Show("Borrado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
