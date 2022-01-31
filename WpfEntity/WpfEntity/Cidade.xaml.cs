using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WpfEntity.POCO;

namespace WpfEntity
{
    /// <summary>
    /// Interaction logic for Cidade.xaml
    /// </summary>
    public partial class BodyCidades : Window
    {
        public BodyCidades()
        {
            InitializeComponent();
            PopulateComboBoxEstados();
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dgCidades.ItemsSource = GetCidades();
        }

        private IList<Estado> GetEstados()
        {
            using (var context = new EFContext())
            {
                return context.Estados.OrderBy(
                    estado => estado.Nome).ToList<Estado>();
            }
        }

        private void PopulateComboBoxEstados()
        {
            cbxEstados.ItemsSource = GetEstados();
            cbxEstados.DisplayMemberPath = "Nome";
            cbxEstados.SelectedValuePath = "Id";

        }
        private void btnGravar_Click(object sender, RoutedEventArgs e)
        {
            var cidade = SaveCidade(new BodyCidades()
            {
                EstadoId = (long)cbxEstados.SelectedValue,
                Nome = txtNome.Text
            });
            txtID.Text = cidade.Id.ToString();
            RefreshDataGrid();

        }
        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            RemoveCidade(Convert.ToInt64(txtID.Text));
            RefreshDataGrid();
        }

        private void UpdateCidade(BodyCidades cidades)
        {
            using (var context = new EFContext())
            {
                var newCidade = context.Cidades.Find(cidades.Id);
                newCidade.Nome = cidades.Nome;
                newCidade.EstadoId = cidades.EstadoId;
                context.SaveChanges();
            }
        }

        private void btnAlterar_Click(Object sender, RoutedEventArgs e)
        {
            UpdateCidade(new BodyCidades()
            {
                Id = Convert.ToInt64(txtID.Text),
                Nome = txtNome.Text,
                EstadoId = (long)cbxEstados.SelectedValue
            });
            RefreshDataGrid();
        }
        private void RemoveCidade(long idCidade)
        {
            using (var context = new EFContext())
            {
                var cidade = context.Cidades.Find(idCidade);
                context.Cidades.Remove(cidade);
                context.SaveChanges();
            }
        }
        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            dgCidades.UnselectAll();
        }

        public BodyCidades SaveCidade(BodyCidades cidade)
        {
            using (var context = new EFContext())
            {
                context.Cidades.Add(cidade);
                context.SaveChanges();
            }
            return cidade;
        }

        private IList GetCidades()
        {
            using (var context = new EFContext())
            {
                var query = (
                    from c in context.Cidades
                    orderby c.Nome
                    select new
                    {
                        c.Id,
                        c.Estado,
                        c.Nome
                    });
                return query.ToList();
            }
        }
    }
}
