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
    public partial class Tipo_doc : Form
    {
        SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=cc;Data Source=DESKTOP-6QJHF2G");
        int id =0;
        public Tipo_doc()
        {
            InitializeComponent();
        }
        void Clear()
        {
            txtEstado2.Text = txtDescripcion.Text = txtCuentaC.Text = "";
            id = 0;
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
               
                param.Add("@id", id );
                param.Add("@cuenta_contable", txtCuentaC.Text.Trim());
                param.Add("@descripcion", txtDescripcion.Text.Trim());
                param.Add("@estado", txtEstado2.Text.Trim());
                sqlcon.Execute("tipo_docAddOrEdit", param, commandType: CommandType.StoredProcedure);
                if (id == 0)
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

        class tipo_doc
        {
            public int id { get; set; }
            public string descripcion { get; set; }
            public string cuenta_contable { get; set; }
            public string estado { get; set; }

        }

        void fillDataGridView()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Searchtext", txtBuscar.Text.Trim());

            List<tipo_doc> list = sqlcon.Query<tipo_doc>("tipo_docViewAllOrSearch", param, commandType: CommandType.StoredProcedure).ToList<tipo_doc>();
            dvgTipo_Doc.DataSource = list;
            dvgTipo_Doc.Columns[0].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView();
                Clear();
            }
            catch (Exception ex ) 
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

        private void dgvTipoDoc_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dvgTipo_Doc.CurrentRow.Index != -1)
                {
                    id = Convert.ToInt32(dvgTipo_Doc.CurrentRow.Cells[0].Value.ToString());
                   txtDescripcion.Text =  dvgTipo_Doc.CurrentRow.Cells[1].Value.ToString();
                    txtCuentaC.Text = dvgTipo_Doc.CurrentRow.Cells[2].Value.ToString();
                    txtEstado2.Text = dvgTipo_Doc.CurrentRow.Cells[3].Value.ToString();
                    btnBorrar.Enabled = true;
                    btnguardar.Text = "Editar";
                }

            }
            catch ( Exception ex)
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
                param.Add("@id",id );
                sqlcon.Execute("tipo_docDelete", param, commandType: CommandType.StoredProcedure);
                Clear();
                fillDataGridView();
                MessageBox.Show("Borrado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTipoDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTipoDoc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
