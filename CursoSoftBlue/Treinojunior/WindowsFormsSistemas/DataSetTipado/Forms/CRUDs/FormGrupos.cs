﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treinojunior.WindowsFormsSistemas.DataSetTipado.Forms.CRUDs
{
    public partial class FormGrupos : Form
    {
        public FormGrupos()
        {
            InitializeComponent();
        }

        private void gruposBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gruposBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);

        }

        private void gruposBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.gruposBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);

        }

        private void FormGrupos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSEstadosECidades.Grupos' table. You can move, or remove it, as needed.
            this.gruposTableAdapter.Fill(this.dSEstadosECidades.Grupos);

        }
    }
}
