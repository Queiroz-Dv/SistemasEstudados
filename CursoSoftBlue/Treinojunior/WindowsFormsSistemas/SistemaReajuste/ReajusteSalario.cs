using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FolhadePagamento
{
    public partial class FormLeituraArquivo : Form
    {
        private ReposFuncionario repos = new ReposFuncionario();
        private BindingSource leituraSource = new BindingSource();

        public FormLeituraArquivo()
        {
            InitializeComponent();
            leituraSource.DataSource = repos.GetAll();
            dgvLeitura.DataSource = leituraSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdListaFuncionarios.ShowDialog() == DialogResult.OK)
            {
                txtArquivo.Text = ofdListaFuncionarios.FileName;
                ProcessaArquivos(txtArquivo.Text);
                if (repos.GetAll().Count > 0)
                {
                    TotalizarValores(repos.GetAll());
                }
            }
        }

        private void TotalizarValores(IList<Funcionario> list)
        {
            double totalSemReajuste = 0, totalComReajuste = 0;
            foreach (var funcionario in list)
            {
                totalSemReajuste += funcionario.Salario;
                totalComReajuste += funcionario.NovoSalario;
            }

            double percentualReajuste = (totalComReajuste - totalSemReajuste) * 100 / totalSemReajuste;

            lblSemReajuste.Text = string.Format("{0:c}", totalSemReajuste);

            lblComReajuste.Text = string.Format("{0:c}", totalComReajuste);

            lblPercentualReajuste.Text = string.Format("{0:n}%", percentualReajuste);
        }

        private void ProcessaArquivos(string nomeArquivo)
        {
            repos.GetAll().Clear();
            string leitorLinha;
            var arquivo = new StreamReader(nomeArquivo);
            while ((leitorLinha = arquivo.ReadLine()) != null)
            {
                var dados = leitorLinha.Split(';');
                var funcionario = new Funcionario
                {
                    Codigo = Convert.ToInt32(dados[0]),
                    Salario = Convert.ToDouble(dados[1])
                };
                repos.Insert(funcionario);
            }
            arquivo.Close();
        }
    }
}
