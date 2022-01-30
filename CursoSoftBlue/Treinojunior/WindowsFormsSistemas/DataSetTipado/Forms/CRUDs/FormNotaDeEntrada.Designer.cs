namespace Treinojunior.WindowsFormsSistemas.DataSetTipado.Forms.CRUDs
{
    partial class FormNotaDeEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idnotaentradaLabel;
            System.Windows.Forms.Label idfornecedorLabel;
            System.Windows.Forms.Label numerodanotaLabel;
            System.Windows.Forms.Label dataemissaoLabel;
            System.Windows.Forms.Label dataentradaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotaDeEntrada));
            this.notadeEntradaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.notadeEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSEstadosECidades = new Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets.DSEstadosECidades();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.notadeEntradaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idnotaentradaLabel1 = new System.Windows.Forms.Label();
            this.idfornecedorComboBox = new System.Windows.Forms.ComboBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numerodanotaTextBox = new System.Windows.Forms.TextBox();
            this.dataemissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataentradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosNotaDeEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.notadeEntradaTableAdapter = new Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets.DSEstadosECidadesTableAdapters.NotadeEntradaTableAdapter();
            this.tableAdapterManager = new Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager();
            this.produtosNotaDeEntradaTableAdapter = new Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets.DSEstadosECidadesTableAdapters.ProdutosNotaDeEntradaTableAdapter();
            this.fornecedoresTableAdapter = new Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets.DSEstadosECidadesTableAdapters.FornecedoresTableAdapter();
            this.produtosTableAdapter = new Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets.DSEstadosECidadesTableAdapters.ProdutosTableAdapter();
            idnotaentradaLabel = new System.Windows.Forms.Label();
            idfornecedorLabel = new System.Windows.Forms.Label();
            numerodanotaLabel = new System.Windows.Forms.Label();
            dataemissaoLabel = new System.Windows.Forms.Label();
            dataentradaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notadeEntradaBindingNavigator)).BeginInit();
            this.notadeEntradaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notadeEntradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeEntradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idnotaentradaLabel
            // 
            idnotaentradaLabel.AutoSize = true;
            idnotaentradaLabel.Location = new System.Drawing.Point(21, 67);
            idnotaentradaLabel.Name = "idnotaentradaLabel";
            idnotaentradaLabel.Size = new System.Drawing.Size(19, 13);
            idnotaentradaLabel.TabIndex = 1;
            idnotaentradaLabel.Text = "Id:";
            // 
            // idfornecedorLabel
            // 
            idfornecedorLabel.AutoSize = true;
            idfornecedorLabel.Location = new System.Drawing.Point(12, 113);
            idfornecedorLabel.Name = "idfornecedorLabel";
            idfornecedorLabel.Size = new System.Drawing.Size(64, 13);
            idfornecedorLabel.TabIndex = 3;
            idfornecedorLabel.Text = "Fornecedor:";
            // 
            // numerodanotaLabel
            // 
            numerodanotaLabel.AutoSize = true;
            numerodanotaLabel.Location = new System.Drawing.Point(227, 67);
            numerodanotaLabel.Name = "numerodanotaLabel";
            numerodanotaLabel.Size = new System.Drawing.Size(48, 13);
            numerodanotaLabel.TabIndex = 5;
            numerodanotaLabel.Text = "Nº Nota:";
            // 
            // dataemissaoLabel
            // 
            dataemissaoLabel.AutoSize = true;
            dataemissaoLabel.Location = new System.Drawing.Point(12, 149);
            dataemissaoLabel.Name = "dataemissaoLabel";
            dataemissaoLabel.Size = new System.Drawing.Size(90, 13);
            dataemissaoLabel.TabIndex = 7;
            dataemissaoLabel.Text = "Data de Emissão:";
            // 
            // dataentradaLabel
            // 
            dataentradaLabel.AutoSize = true;
            dataentradaLabel.Location = new System.Drawing.Point(223, 149);
            dataentradaLabel.Name = "dataentradaLabel";
            dataentradaLabel.Size = new System.Drawing.Size(88, 13);
            dataentradaLabel.TabIndex = 9;
            dataentradaLabel.Text = "Data de Entrada:";
            // 
            // notadeEntradaBindingNavigator
            // 
            this.notadeEntradaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.notadeEntradaBindingNavigator.BindingSource = this.notadeEntradaBindingSource;
            this.notadeEntradaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notadeEntradaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.notadeEntradaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.notadeEntradaBindingNavigatorSaveItem});
            this.notadeEntradaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notadeEntradaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.notadeEntradaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.notadeEntradaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.notadeEntradaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.notadeEntradaBindingNavigator.Name = "notadeEntradaBindingNavigator";
            this.notadeEntradaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.notadeEntradaBindingNavigator.Size = new System.Drawing.Size(475, 25);
            this.notadeEntradaBindingNavigator.TabIndex = 0;
            this.notadeEntradaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // notadeEntradaBindingSource
            // 
            this.notadeEntradaBindingSource.DataMember = "NotadeEntrada";
            this.notadeEntradaBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // dSEstadosECidades
            // 
            this.dSEstadosECidades.DataSetName = "DSEstadosECidades";
            this.dSEstadosECidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // notadeEntradaBindingNavigatorSaveItem
            // 
            this.notadeEntradaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notadeEntradaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notadeEntradaBindingNavigatorSaveItem.Image")));
            this.notadeEntradaBindingNavigatorSaveItem.Name = "notadeEntradaBindingNavigatorSaveItem";
            this.notadeEntradaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.notadeEntradaBindingNavigatorSaveItem.Text = "Save Data";
            this.notadeEntradaBindingNavigatorSaveItem.Click += new System.EventHandler(this.notadeEntradaBindingNavigatorSaveItem_Click);
            // 
            // idnotaentradaLabel1
            // 
            this.idnotaentradaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notadeEntradaBindingSource, "idnotaentrada", true));
            this.idnotaentradaLabel1.Location = new System.Drawing.Point(115, 64);
            this.idnotaentradaLabel1.Name = "idnotaentradaLabel1";
            this.idnotaentradaLabel1.Size = new System.Drawing.Size(106, 23);
            this.idnotaentradaLabel1.TabIndex = 2;
            this.idnotaentradaLabel1.Text = "label1";
            // 
            // idfornecedorComboBox
            // 
            this.idfornecedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.notadeEntradaBindingSource, "idfornecedor", true));
            this.idfornecedorComboBox.DataSource = this.fornecedoresBindingSource;
            this.idfornecedorComboBox.DisplayMember = "nome";
            this.idfornecedorComboBox.FormattingEnabled = true;
            this.idfornecedorComboBox.Location = new System.Drawing.Point(118, 110);
            this.idfornecedorComboBox.Name = "idfornecedorComboBox";
            this.idfornecedorComboBox.Size = new System.Drawing.Size(299, 21);
            this.idfornecedorComboBox.TabIndex = 4;
            this.idfornecedorComboBox.ValueMember = "idfornecedor";
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // numerodanotaTextBox
            // 
            this.numerodanotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notadeEntradaBindingSource, "numerodanota", true));
            this.numerodanotaTextBox.Location = new System.Drawing.Point(281, 64);
            this.numerodanotaTextBox.Name = "numerodanotaTextBox";
            this.numerodanotaTextBox.Size = new System.Drawing.Size(136, 20);
            this.numerodanotaTextBox.TabIndex = 6;
            // 
            // dataemissaoDateTimePicker
            // 
            this.dataemissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notadeEntradaBindingSource, "dataemissao", true));
            this.dataemissaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataemissaoDateTimePicker.Location = new System.Drawing.Point(108, 143);
            this.dataemissaoDateTimePicker.Name = "dataemissaoDateTimePicker";
            this.dataemissaoDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.dataemissaoDateTimePicker.TabIndex = 8;
            // 
            // dataentradaDateTimePicker
            // 
            this.dataentradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notadeEntradaBindingSource, "dataentrada", true));
            this.dataentradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataentradaDateTimePicker.Location = new System.Drawing.Point(317, 143);
            this.dataentradaDateTimePicker.Name = "dataentradaDateTimePicker";
            this.dataentradaDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.dataentradaDateTimePicker.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProdutos);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Location = new System.Drawing.Point(12, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 242);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvProdutos.DataSource = this.produtosNotaDeEntradaBindingSource;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 41);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(455, 198);
            this.dgvProdutos.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idproduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precocustocompra";
            this.dataGridViewTextBoxColumn4.HeaderText = "Custo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quantidadecomprada";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // produtosNotaDeEntradaBindingSource
            // 
            this.produtosNotaDeEntradaBindingSource.DataMember = "FK_ProdutosNotaDeEntrada_NotadeEntrada";
            this.produtosNotaDeEntradaBindingSource.DataSource = this.notadeEntradaBindingSource;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(455, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // notadeEntradaTableAdapter
            // 
            this.notadeEntradaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CidadesTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.EstadosTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = null;
            this.tableAdapterManager.NotadeEntradaTableAdapter = this.notadeEntradaTableAdapter;
            this.tableAdapterManager.ProdutosNotaDeEntradaTableAdapter = this.produtosNotaDeEntradaTableAdapter;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtosNotaDeEntradaTableAdapter
            // 
            this.produtosNotaDeEntradaTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // FormNotaDeEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(idnotaentradaLabel);
            this.Controls.Add(this.idnotaentradaLabel1);
            this.Controls.Add(idfornecedorLabel);
            this.Controls.Add(this.idfornecedorComboBox);
            this.Controls.Add(numerodanotaLabel);
            this.Controls.Add(this.numerodanotaTextBox);
            this.Controls.Add(dataemissaoLabel);
            this.Controls.Add(this.dataemissaoDateTimePicker);
            this.Controls.Add(dataentradaLabel);
            this.Controls.Add(this.dataentradaDateTimePicker);
            this.Controls.Add(this.notadeEntradaBindingNavigator);
            this.Name = "FormNotaDeEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nota De Entrada";
            this.Load += new System.EventHandler(this.FormNotaDeEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notadeEntradaBindingNavigator)).EndInit();
            this.notadeEntradaBindingNavigator.ResumeLayout(false);
            this.notadeEntradaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notadeEntradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeEntradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.DSEstadosECidades dSEstadosECidades;
        private System.Windows.Forms.BindingSource notadeEntradaBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.NotadeEntradaTableAdapter notadeEntradaTableAdapter;
        private DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notadeEntradaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton notadeEntradaBindingNavigatorSaveItem;
        private DataSets.DSEstadosECidadesTableAdapters.ProdutosNotaDeEntradaTableAdapter produtosNotaDeEntradaTableAdapter;
        private System.Windows.Forms.Label idnotaentradaLabel1;
        private System.Windows.Forms.ComboBox idfornecedorComboBox;
        private System.Windows.Forms.TextBox numerodanotaTextBox;
        private System.Windows.Forms.DateTimePicker dataemissaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataentradaDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingSource produtosNotaDeEntradaBindingSource;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private DataSets.DSEstadosECidadesTableAdapters.ProdutosTableAdapter produtosTableAdapter;
    }
}