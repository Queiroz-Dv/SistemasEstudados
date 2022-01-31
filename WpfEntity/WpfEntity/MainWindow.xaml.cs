﻿using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WpfEntity.POCO;

namespace WpfEntity
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RefreshDataGrid();
        }
        private void RefreshDataGrid()
        {
            dgEstados.ItemsSource = GetEstados();
        }

        private IList<Estado> GetEstados()
        {
            using (var context = new EFContext())
            {
                return context.Estados.ToList();
            }
        }

        private Estado SaveEstado(Estado estado)
        {
            using (var context = new EFContext())
            {
                context.Estados.Add(estado);
                context.SaveChanges();
            }
            return estado;
        }

        private void btnGravar_Click(object sender, RoutedEventArgs e)
        {
            var estado = SaveEstado(new Estado()
            {
                UF = txtUF.Text,
                Nome = txtNome.Text
            });
            txtID.Text = estado.Id.ToString();
            RefreshDataGrid();
        }
    }
}
