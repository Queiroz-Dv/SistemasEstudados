﻿using ProjectController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class ViewFornecedor : Form
    {
        private FornecedorController controller = new FornecedorController();
        public ViewFornecedor()
        {
            InitializeComponent();
        }
    }
}
