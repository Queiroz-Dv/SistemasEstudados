using ProjectController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Treinojunior.ProjectModel;

namespace ViewProject
{
    public partial class ViewFornecedor : Form
    {
        private FornecedorController controller = new FornecedorController();
        public ViewFornecedor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor()
            {
                ID = (txtID.Text == string.Empty ? Guid.NewGuid() : new Guid(txtID.Text)),
                Nome = txtNome.Text,
                CNPJ = txtCNPJ.Text
            };
            fornecedor = (txtID.Text == string.Empty ? this.controller.Insert(fornecedor) :
                          this.controller.Update(fornecedor));
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = this.controller.GetAll();
            ClearControls();
        }

        private void ClearControls()
        {
            dgvFornecedores.ClearSelection();
            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            txtNome.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
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
                this.controller.Remove(
                    new Fornecedor()
                    {
                        ID = new Guid(txtID.Text)
                    });
                dgvFornecedores.DataSource = null;
                dgvFornecedores.DataSource = this.controller.GetAll();
                ClearControls();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
