using System;
using System.IO;
using System.Windows.Forms;

namespace Treinojunior.WindowsFormsSistemas.SistemaArquivamento
{
    public partial class GeradorArquivo : Form
    {
        public GeradorArquivo()
        {
            InitializeComponent();
            dgvFuncionarios.ColumnCount = 2;
            dgvFuncionarios.Columns[0].HeaderText = "Nome";
            dgvFuncionarios.Columns[0].Width = 230;

            dgvFuncionarios.Columns[1].HeaderText = "Salário";
            dgvFuncionarios.Columns[1].Width = 67;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLinhasRegistro_Click(object sender, EventArgs e)
        {
            int numeroFuncionarios = Convert.ToInt16(txtNumeroFuncionarios.Text);
            if (numeroFuncionarios < 1)
            {
                numeroFuncionarios = 1;
            }
            int i = 0;

            do
            {
                var linhaTabela = new DataGridViewRow();
                linhaTabela.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                linhaTabela.Cells.Add(new DataGridViewTextBoxCell { Value = 0 });
                dgvFuncionarios.Rows.Add(linhaTabela);

            } while (++i < numeroFuncionarios);

            txtNumeroFuncionarios.Enabled = false;
            btnCriar.Enabled = true;
            btnReiniciar.Enabled = true;
            btnLinhasRegistro.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.Rows.Clear();
            txtNumeroFuncionarios.Text = string.Empty;
            txtNumeroFuncionarios.Enabled = true;
            btnCriar.Enabled = false;
            btnReiniciar.Enabled = false;
            btnLinhasRegistro.Enabled = true;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (!Validacao())
            {
                MessageBox.Show("Os dados possuem problemas. " +
                                "Por favor, verifique se os nomes e os salários estão corretos.");
            }
            else if (sfdGravarArquivo.ShowDialog() == DialogResult.OK)
            {
                GerarArquivo();
                MessageBox.Show("Arquivo gerado com sucesso!");
            }
        }

        private void GerarArquivo()
        {
            StreamWriter writer = new StreamWriter(sfdGravarArquivo.FileName, true);
            for (int a = 0; a < dgvFuncionarios.Rows.Count; a++)
            {
                writer.WriteLine(dgvFuncionarios.Rows[a].Cells[0].Value.ToString() +
                    ";" + dgvFuncionarios.Rows[a].Cells[1].Value.ToString());
            }
            writer.Close();
        }

        private bool Validacao()
        {
            int i = 0;
            bool dadosValidados = true;
            do
            {
                if (string.IsNullOrWhiteSpace(dgvFuncionarios.Rows[i].Cells[0].Value.ToString()))
                {
                    dadosValidados = false;
                }
                if (!Double.TryParse(dgvFuncionarios.Rows[i].Cells[1].Value.ToString(), out double stringToDouble))
                {
                    dadosValidados = false;
                }
            } while (++i < dgvFuncionarios.Rows.Count);
            return dadosValidados;
        }
    }
}
