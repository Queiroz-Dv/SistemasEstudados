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
           var fornecedor = this.controller.Insert(
                new Fornecedor()
                {
                    ID = Guid.NewGuid(),
                    Nome = txtNome.Text,
                    CNPJ = txtCNPJ.Text
                }
                );

            txtID.Text = fornecedor.ID.ToString();
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = this.controller.GetAll();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
