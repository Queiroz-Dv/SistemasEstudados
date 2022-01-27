using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treinojunior.WindowsFormsSistemas.TesteDataSet
{
    public partial class DataSetProject : Form
    {
        private DataSet dsEstadosCidades;
        public DataSetProject()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            dsEstadosCidades = InitializeDataSet();
            MessageBox.Show("DataSet inicializado");
        }

        private DataSet InitializeDataSet()
        {
            DataTable dtEstados = new DataTable("Estados");
            dtEstados.Columns.Add("id");
            dtEstados.Columns.Add("uf");
            dtEstados.Columns.Add("nome");

            DataTable dtCidades = new DataTable("Cidades");
            dtEstados.Columns.Add("id");
            dtEstados.Columns.Add("idestado");
            dtEstados.Columns.Add("nome");

            DataSet dsEstadosCidades = new DataSet("EstadosCidades");
            dsEstadosCidades.Tables.Add(dtEstados);
            dsEstadosCidades.Tables.Add(dtCidades);

            DataRelation drCidadeEstado = new DataRelation("CidadesEstados",
                dtEstados.Columns["id"], dtCidades.Columns["idestado"]);
            dsEstadosCidades.Relations.Add(drCidadeEstado);

            return dsEstadosCidades;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            DataTable dtEstados = dsEstadosCidades.Tables["Estados"];
            dtEstados.Rows.Add(1, "PR", "Paraná");
            dtEstados.Rows.Add(2, "SP", "São Paulo");
            dtEstados.Rows.Add(3, "SC", "Santa Catarina");

            DataTable dtCidades = dsEstadosCidades.Tables["Cidades"];
            dtCidades.Rows.Add(1, 1, "Foz do Iguaçu");
            dtCidades.Rows.Add(2, 1, "Medianeira");
            dtCidades.Rows.Add(3, 1, "Curitiba");
            dtCidades.Rows.Add(4, 2, "São Paulo");
            dtCidades.Rows.Add(5, 2, "Ilha Solteira");
            dtCidades.Rows.Add(6, 3, "Florianópolis");

            MessageBox.Show("Dados inseridos");
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            tcResultados.SelectedTab = tpgXML;
            txtXML.Text = dsEstadosCidades.GetXml();
        }

        private void btnControle_Click(object sender, EventArgs e)
        {
            BindingSource bsMaster = new BindingSource();
            BindingSource bsDetails = new BindingSource();

            bsMaster.DataSource = dsEstadosCidades;
            bsMaster.DataMember = "Estados";
            bsDetails.DataSource = bsMaster;
            bsDetails.DataMember = "CidadesEstados";

            tcResultados.SelectedTab = tpgComboEGrid;
            cbxEstados.DataSource = bsMaster;
            cbxEstados.DisplayMember = "nome";
            cbxEstados.ValueMember = "id";
            dgvCidades.DataSource = bsDetails;
        }
    }
}
