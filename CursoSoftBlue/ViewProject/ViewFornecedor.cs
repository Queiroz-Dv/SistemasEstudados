using ADO_Base;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Treinojunior.ProjectModel;

namespace ViewProject
{
    public partial class ViewFornecedor : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
        private Fornecedor fornecedorAtual;
        private DAL_Fornecedor dal = new DAL_Fornecedor();

        public ViewFornecedor(DAL_Fornecedor dAL_Fornecedor)
        {
            InitializeComponent();
            GetAllFornecedores();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            dal.Save(new Fornecedor
            {
                ID = string.IsNullOrEmpty(txtID.Text) ? (long?)null : Convert.ToInt64(txtID.Text),
                Nome = txtNome.Text,
                CNPJ = txtCNPJ.Text
            });
            MessageBox.Show("Manutenção realizada com sucesso");

        }

        private void ClearControls()
        {
            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            GetAllFornecedores();
            dgvFornecedores.ClearSelection();
            this.fornecedorAtual = null;
            txtNome.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            MenuAdm menuAdm = new MenuAdm();
            this.Hide();
            menuAdm.ShowDialog();
            this.Visible = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dgvFornecedores_SelectionChanged(object sender, EventArgs e)
        {
            txtID.Text = dgvFornecedores.CurrentRow.Cells[0].Value.ToString();

            txtNome.Text = dgvFornecedores.CurrentRow.Cells[1].Value.ToString();

            txtCNPJ.Text = dgvFornecedores.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Selecione o Fornecedor a ser removido no grid");
            }
            else
            {
                this.dal.RemoveById(this.fornecedorAtual.ID);
                ClearControls();
                MessageBox.Show("Fornecedor removido com sucesso");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void GetAllFornecedores()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
            var connection = new SqlConnection(connectionString);

            var adapter = new SqlDataAdapter("select id, cnpj, nome from FORNECEDORES", connection);
            var builder = new SqlCommandBuilder(adapter);
            var table = new DataTable();
            adapter.Fill(table);

            dgvFornecedores.DataSource = table;
            connection.Close();
        }

        private Fornecedor GetFornecedorORMByID(long ID)
        {
            Fornecedor fornecedor = new Fornecedor();
            var connection = DBConnection.DB_Connection;
            var command = new SqlCommand("select id, cnpj, nome from FORNECEDORES where id = @id", connection);
            command.Parameters.AddWithValue("@id", ID);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    fornecedor.ID = reader.GetInt32(0);
                    fornecedor.CNPJ = reader.GetString(1);
                    fornecedor.Nome = reader.GetString(2);
                }
                connection.Close();
                return fornecedor;
            }
        }

        private void dgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            this.fornecedorAtual = GetFornecedorORMByID(Convert.ToInt64(dgvFornecedores.Rows[e.RowIndex].Cells[0].Value));
            txtID.Text = this.fornecedorAtual.ID.ToString();
            txtNome.Text = this.fornecedorAtual.Nome;
            txtCNPJ.Text = this.fornecedorAtual.CNPJ;
        }
    }
}
