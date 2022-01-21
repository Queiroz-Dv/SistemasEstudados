using ConsumoEnergiaCondominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Treinojunior.ProjetosGrandes.SistemaConsumoEnergia
{
    public partial class ConsumoEnergia : Form
    {
        //Esse primeiro é uma coleção
        private IList<BaseLeitura> baseLeituras = new BindingList<BaseLeitura>();

        //Esse segundo representa um objeto que serve como fonte dados para controle visual 
        private BindingSource sourceLeitura = new BindingSource();

        public ConsumoEnergia()
        {
            InitializeComponent();
            sourceLeitura.DataSource = baseLeituras;
            dataGridView1.DataSource = sourceLeitura;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarConsumo(txtCasa.Text, Convert.ToDouble(txtConsumo.Text));
        }

        private void RegistrarConsumo(string casa, double consumo)
        {
            BaseLeitura baseLeitura = new BaseLeitura(casa, consumo);
            if (baseLeituras.Contains(baseLeitura))
            {
                MessageBox.Show("Esta casa já foi registrada",
                    "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                this.baseLeituras.Add(baseLeitura);
                InicializarForm();
            }
        }

        private void InicializarForm()
        {
            txtCasa.Clear();
            txtConsumo.Clear();
            txtCasa.Focus();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            Processar(dataGridView1);
        }

        private void Processar(DataGridView dgv)
        {
            DataGridViewCell cell = dataGridView1.Rows[0].Cells[0];
            this.baseLeituras.Add(new BaseLeitura("Total", 0));
            for (int i = 0; i < 3; i++)
            {
                dgv.Rows[dataGridView1.Rows.Count - 1].Cells[i].Style.BackColor = Color.DarkGray;

                dgv.Rows[dataGridView1.Rows.Count - 1].Cells[i].Style.ForeColor = Color.White;

                dgv.Rows[dataGridView1.Rows.Count - 1].Cells[i].Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
            }
            //Construção diferente
            double totalConsumo = 0, totalDesconto = 0;
            foreach (var baseLeitura in baseLeituras)
            {
                totalConsumo += baseLeitura.Consumo;
                totalDesconto += baseLeitura.Desconto;
            }

            dgv[0, dgv.Rows.Count - 1].Value = "Total";
            dgv[1, dgv.Rows.Count - 1].Value = totalConsumo.ToString("N");
            dgv[2, dgv.Rows.Count - 1].Value = totalDesconto.ToString("N");

            lblResult.Text = "Total consumo sem desconto: " + (totalConsumo - totalDesconto).ToString("N");

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
