using System;
using System.Windows.Forms;
using Treinojunior.WindowsFormsSistemas.DataSetTipado.Forms.CRUDs;

namespace Treinojunior.WindowsFormsSistemas.DataSetTipado
{
    public partial class MenuDataSetTipado : Form
    {
        public MenuDataSetTipado()
        {
            InitializeComponent();
        }

        private void btnEstados_Click(object sender, EventArgs e)
        {
            FormEstados frm = new FormEstados();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnCidades_Click(object sender, EventArgs e)
        {
            FormCidades frm = new FormCidades();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            new FormFornecedores().ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            new FormProdutos().ShowDialog();
        }

        private void btnNotasDeEntrada_Click(object sender, EventArgs e)
        {
            new FormNotaDeEntrada().ShowDialog();
        }
    }
}
