using ProjectController;
using System;
using System.Windows.Forms;
using Treinojunior.ProjectModel;

namespace ViewProject
{
    public partial class ViewProduto : Form
    {
        private NotaEntradaController controller;
        private FornecedorController fornecedorController;
        private ProdutoController produtoController;

        private InputNota notaAtual;
        public ViewProduto(NotaEntradaController controller,
            FornecedorController fornecedorController,
            ProdutoController produtoController)
        {
            InitializeComponent();
            this.controller = controller;
            this.fornecedorController = fornecedorController;
            this.produtoController = produtoController;
            InicilizarComboBoxs();

        }

        private void InicilizarComboBoxs()
        {
            cmbProduto.Items.Clear();
            foreach (Produto produto in this.produtoController.GetAll())
            {
                cmbProduto.Items.Add(produto);
            }
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            ClearControlsProduto();
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Selecione a nota que terá inserção de produtos no grid")
            }
            else
            {
                ChangeStatusOfControls(true);
            }
        }

        private void ChangeStatusOfControls(bool newStatus)
        {
            cmbProduto.Enabled = newStatus;
            txtCusto.Enabled = newStatus;
            txtQuantidade.Enabled = newStatus;
            btnNovo.Enabled = !newStatus;
            btnSalvar.Enabled = newStatus;
            btnCancelar.Enabled = newStatus;
            btnRemover.Enabled = newStatus;
        }

        private void ClearControlsProduto()
        {
            dgvProduto.ClearSelection();
            txtID.Text = string.Empty;
            cmbProduto.SelectedIndex = -1;
            txtCusto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            cmbProduto.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var produtoNota = new InputProdutoNota()
            {
                ID = (txtID.Text == string.Empty ?
                Guid.NewGuid() : new Guid(txtID.Text)),
                PrecoCustoCompra = Convert.ToDouble(txtCusto.Text),
                ProdutoNota = (Produto)cmbProduto.SelectedItem,
                QuantidadeComprada = Convert.ToDouble(txtQuantidade.Text)
            };
            this.notaAtual.GravarProduto(produtoNota);
            this.notaAtual = this.controller.Update(this.notaAtual);
            ChangeStatusOfControls(false);

            ClearControlsProduto();
        }

        private void UpdateProdutosGrid()
        {
            dgvProduto.DataSource = null;
            if (this.notaAtual.Produtos.Count > 0)
            {
                dgvProduto.DataSource = this.notaAtual.Produtos;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControlsProduto();
            ChangeStatusOfControls(false);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            this.notaAtual.RemoverProduto(new InputProdutoNota()
            {
                ID = new Guid(txtID.Text)
            });
            this.controller.Update(this.notaAtual);
            UpdateProdutosGrid();
            ClearControlsProduto();
            ChangeStatusOfControls(false);
        }
    }
}
