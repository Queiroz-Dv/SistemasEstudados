using ADO_Base;
using System;
using System.Windows.Forms;
using Treinojunior.ProjectModel;

namespace ViewProject
{
    public partial class ViewNotaEntrada : Form
    {
        private DAL_NotaEntrada dal = new DAL_NotaEntrada();
        private DAL_Fornecedor DAL_Fornecedor = new DAL_Fornecedor();
        private DAL_Produto DAL_Produto = new DAL_Produto();
        private NotaEntrada notaAtual;

        public ViewNotaEntrada()
        {
            InitializeComponent();
            InicilizarComboBoxs();
            GetAllNotas();
        }

        private void GetAllNotas()
        {
            dgvNota.DataSource = dal.GetAllAsDataTable();
        }

        private void InicilizarComboBoxs()
        {
            cmbFornecedor.Items.Clear();
            foreach (Fornecedor fornecedor in this.DAL_Fornecedor.GetAllAsList())
            {
                cmbFornecedor.Items.Add(fornecedor);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }

        private void ClearControlsNota()
        {
            dgvNota.ClearSelection();
            txtID.Text = string.Empty;
            cmbFornecedor.SelectedIndex = -1;
            txtNumero.Text = string.Empty;
            dtpEmissao.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Now;
            cmbFornecedor.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            dal.Save(new NotaEntrada()
            {
                ID = string.IsNullOrEmpty(txtID.Text) ? (long?)null : Convert.ToInt64(txtID.Text),
                Numero = txtNumero.Text,
                DataEmissao = dtpEmissao.Value,
                DataEntrada = dtpEntrada.Value,
                FornecedorNota = (Fornecedor)cmbFornecedor.SelectedItem
            });
            MessageBox.Show("Manutenção realizada com sucesso");
            ClearControlsNota();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Selecione a nota a ser removida no grid");
            }
            else
            {
                this.dal.RemoveById(this.notaAtual.ID);
                ClearControlsNota();
                MessageBox.Show("Nota removida com sucesso");
            }
        }

        private void UpdateGrid()
        {
            dgvNota.DataSource = null;
            if (this.notaAtual.Produtos.Count > 0)
            {
                dgvNota.DataSource = this.notaAtual.Produtos;
            }
        }

        private void dgvNota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex< 0 || e.ColumnIndex<0)
            {
                return;
            }
            this.notaAtual = dal.GetById(Convert.ToInt64(dgvNota.Rows[e.RowIndex].Cells[0].Value));
            txtID.Text = notaAtual.ID.ToString();
            txtNumero.Text = notaAtual.Numero;
            dtpEmissao.Value = notaAtual.DataEmissao;
            dtpEntrada.Value = notaAtual.DataEntrada;
            cmbFornecedor.SelectedItem = notaAtual.FornecedorNota;
        }
    }
}
