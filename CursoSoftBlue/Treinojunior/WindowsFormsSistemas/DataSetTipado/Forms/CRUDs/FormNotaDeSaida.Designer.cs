namespace Treinojunior.WindowsFormsSistemas.DataSetTipado.Forms.CRUDs
{
    partial class FormNotaDeSaida
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
            System.Windows.Forms.Label idnotadevendaLabel;
            System.Windows.Forms.Label idclienteLabel;
            System.Windows.Forms.Label numerodanotaLabel;
            System.Windows.Forms.Label datavendaLabel;
            System.Windows.Forms.Label notafechadaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotaDeSaida));
            this.dSEstadosECidades = new Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets.DSEstadosECidades();
            this.notasDeVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasDeVendaTableAdapter = new Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets.DSEstadosECidadesTableAdapters.NotasDeVendaTableAdapter();
            this.tableAdapterManager = new Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager();
            this.produtosNotaDeSaidaTableAdapter = new Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets.DSEstadosECidadesTableAdapters.ProdutosNotaDeSaidaTableAdapter();
            this.notasDeVendaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnbAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bnbRemove = new System.Windows.Forms.ToolStripButton();
            this.bnbFirst = new System.Windows.Forms.ToolStripButton();
            this.bnbPrior = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bnbRecordNo = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bnbNext = new System.Windows.Forms.ToolStripButton();
            this.bnbLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bnbSave = new System.Windows.Forms.ToolStripButton();
            this.bnbEdit = new System.Windows.Forms.ToolStripButton();
            this.bnbFecharNota = new System.Windows.Forms.ToolStripButton();
            this.gbxDadosDaNota = new System.Windows.Forms.GroupBox();
            this.idnotadevendaLabel1 = new System.Windows.Forms.Label();
            this.idclienteComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numerodanotaTextBox = new System.Windows.Forms.TextBox();
            this.datavendaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notafechadaLabel1 = new System.Windows.Forms.Label();
            this.produtosNotaDeSaidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxProdutosDaNota = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.clientesTableAdapter = new Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets.DSEstadosECidadesTableAdapters.ClientesTableAdapter();
            this.produtosTableAdapter = new Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets.DSEstadosECidadesTableAdapters.ProdutosTableAdapter();
            idnotadevendaLabel = new System.Windows.Forms.Label();
            idclienteLabel = new System.Windows.Forms.Label();
            numerodanotaLabel = new System.Windows.Forms.Label();
            datavendaLabel = new System.Windows.Forms.Label();
            notafechadaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingNavigator)).BeginInit();
            this.notasDeVendaBindingNavigator.SuspendLayout();
            this.gbxDadosDaNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeSaidaBindingSource)).BeginInit();
            this.gbxProdutosDaNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idnotadevendaLabel
            // 
            idnotadevendaLabel.AutoSize = true;
            idnotadevendaLabel.Location = new System.Drawing.Point(55, 16);
            idnotadevendaLabel.Name = "idnotadevendaLabel";
            idnotadevendaLabel.Size = new System.Drawing.Size(81, 13);
            idnotadevendaLabel.TabIndex = 11;
            idnotadevendaLabel.Text = "idnotadevenda:";
            // 
            // idclienteLabel
            // 
            idclienteLabel.AutoSize = true;
            idclienteLabel.Location = new System.Drawing.Point(55, 45);
            idclienteLabel.Name = "idclienteLabel";
            idclienteLabel.Size = new System.Drawing.Size(49, 13);
            idclienteLabel.TabIndex = 13;
            idclienteLabel.Text = "idcliente:";
            // 
            // numerodanotaLabel
            // 
            numerodanotaLabel.AutoSize = true;
            numerodanotaLabel.Location = new System.Drawing.Point(55, 72);
            numerodanotaLabel.Name = "numerodanotaLabel";
            numerodanotaLabel.Size = new System.Drawing.Size(78, 13);
            numerodanotaLabel.TabIndex = 15;
            numerodanotaLabel.Text = "numerodanota:";
            // 
            // datavendaLabel
            // 
            datavendaLabel.AutoSize = true;
            datavendaLabel.Location = new System.Drawing.Point(55, 99);
            datavendaLabel.Name = "datavendaLabel";
            datavendaLabel.Size = new System.Drawing.Size(61, 13);
            datavendaLabel.TabIndex = 17;
            datavendaLabel.Text = "datavenda:";
            // 
            // notafechadaLabel
            // 
            notafechadaLabel.AutoSize = true;
            notafechadaLabel.Location = new System.Drawing.Point(55, 118);
            notafechadaLabel.Name = "notafechadaLabel";
            notafechadaLabel.Size = new System.Drawing.Size(70, 13);
            notafechadaLabel.TabIndex = 19;
            notafechadaLabel.Text = "notafechada:";
            // 
            // dSEstadosECidades
            // 
            this.dSEstadosECidades.DataSetName = "DSEstadosECidades";
            this.dSEstadosECidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasDeVendaBindingSource
            // 
            this.notasDeVendaBindingSource.DataMember = "NotasDeVenda";
            this.notasDeVendaBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // notasDeVendaTableAdapter
            // 
            this.notasDeVendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CidadesTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.EstadosTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = null;
            this.tableAdapterManager.NotadeEntradaTableAdapter = null;
            this.tableAdapterManager.NotasDeVendaTableAdapter = this.notasDeVendaTableAdapter;
            this.tableAdapterManager.ProdutosNotaDeEntradaTableAdapter = null;
            this.tableAdapterManager.ProdutosNotaDeSaidaTableAdapter = this.produtosNotaDeSaidaTableAdapter;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Treinojunior.WindowsFormsSistemas.DataSetTipado.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtosNotaDeSaidaTableAdapter
            // 
            this.produtosNotaDeSaidaTableAdapter.ClearBeforeFill = true;
            // 
            // notasDeVendaBindingNavigator
            // 
            this.notasDeVendaBindingNavigator.AddNewItem = this.bnbAdd;
            this.notasDeVendaBindingNavigator.BindingSource = this.notasDeVendaBindingSource;
            this.notasDeVendaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notasDeVendaBindingNavigator.DeleteItem = this.bnbRemove;
            this.notasDeVendaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnbFirst,
            this.bnbPrior,
            this.bindingNavigatorSeparator,
            this.bnbRecordNo,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bnbNext,
            this.bnbLast,
            this.bindingNavigatorSeparator2,
            this.bnbAdd,
            this.bnbRemove,
            this.bnbSave,
            this.bnbEdit,
            this.bnbFecharNota});
            this.notasDeVendaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notasDeVendaBindingNavigator.MoveFirstItem = this.bnbFirst;
            this.notasDeVendaBindingNavigator.MoveLastItem = this.bnbLast;
            this.notasDeVendaBindingNavigator.MoveNextItem = this.bnbNext;
            this.notasDeVendaBindingNavigator.MovePreviousItem = this.bnbPrior;
            this.notasDeVendaBindingNavigator.Name = "notasDeVendaBindingNavigator";
            this.notasDeVendaBindingNavigator.PositionItem = this.bnbRecordNo;
            this.notasDeVendaBindingNavigator.Size = new System.Drawing.Size(456, 25);
            this.notasDeVendaBindingNavigator.TabIndex = 0;
            this.notasDeVendaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bnbAdd
            // 
            this.bnbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbAdd.Image = ((System.Drawing.Image)(resources.GetObject("bnbAdd.Image")));
            this.bnbAdd.Name = "bnbAdd";
            this.bnbAdd.RightToLeftAutoMirrorImage = true;
            this.bnbAdd.Size = new System.Drawing.Size(23, 22);
            this.bnbAdd.Text = "Add new";
            this.bnbAdd.Click += new System.EventHandler(this.bnbAdd_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bnbRemove
            // 
            this.bnbRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbRemove.Image = ((System.Drawing.Image)(resources.GetObject("bnbRemove.Image")));
            this.bnbRemove.Name = "bnbRemove";
            this.bnbRemove.RightToLeftAutoMirrorImage = true;
            this.bnbRemove.Size = new System.Drawing.Size(23, 22);
            this.bnbRemove.Text = "Delete";
            this.bnbRemove.Click += new System.EventHandler(this.bnbRemove_Click);
            // 
            // bnbFirst
            // 
            this.bnbFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbFirst.Image = ((System.Drawing.Image)(resources.GetObject("bnbFirst.Image")));
            this.bnbFirst.Name = "bnbFirst";
            this.bnbFirst.RightToLeftAutoMirrorImage = true;
            this.bnbFirst.Size = new System.Drawing.Size(23, 22);
            this.bnbFirst.Text = "Move first";
            // 
            // bnbPrior
            // 
            this.bnbPrior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbPrior.Image = ((System.Drawing.Image)(resources.GetObject("bnbPrior.Image")));
            this.bnbPrior.Name = "bnbPrior";
            this.bnbPrior.RightToLeftAutoMirrorImage = true;
            this.bnbPrior.Size = new System.Drawing.Size(23, 22);
            this.bnbPrior.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bnbRecordNo
            // 
            this.bnbRecordNo.AccessibleName = "Position";
            this.bnbRecordNo.AutoSize = false;
            this.bnbRecordNo.Name = "bnbRecordNo";
            this.bnbRecordNo.Size = new System.Drawing.Size(50, 23);
            this.bnbRecordNo.Text = "0";
            this.bnbRecordNo.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bnbNext
            // 
            this.bnbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbNext.Image = ((System.Drawing.Image)(resources.GetObject("bnbNext.Image")));
            this.bnbNext.Name = "bnbNext";
            this.bnbNext.RightToLeftAutoMirrorImage = true;
            this.bnbNext.Size = new System.Drawing.Size(23, 22);
            this.bnbNext.Text = "Move next";
            // 
            // bnbLast
            // 
            this.bnbLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbLast.Image = ((System.Drawing.Image)(resources.GetObject("bnbLast.Image")));
            this.bnbLast.Name = "bnbLast";
            this.bnbLast.RightToLeftAutoMirrorImage = true;
            this.bnbLast.Size = new System.Drawing.Size(23, 22);
            this.bnbLast.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bnbSave
            // 
            this.bnbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbSave.Image = ((System.Drawing.Image)(resources.GetObject("bnbSave.Image")));
            this.bnbSave.Name = "bnbSave";
            this.bnbSave.Size = new System.Drawing.Size(23, 22);
            this.bnbSave.Text = "Save Data";
            this.bnbSave.Click += new System.EventHandler(this.notasDeVendaBindingNavigatorSaveItem_Click);
            // 
            // bnbEdit
            // 
            this.bnbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbEdit.Image = ((System.Drawing.Image)(resources.GetObject("bnbEdit.Image")));
            this.bnbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnbEdit.Name = "bnbEdit";
            this.bnbEdit.Size = new System.Drawing.Size(23, 22);
            this.bnbEdit.Text = "Editar";
            this.bnbEdit.Click += new System.EventHandler(this.bnbEdit_Click);
            // 
            // bnbFecharNota
            // 
            this.bnbFecharNota.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbFecharNota.Image = ((System.Drawing.Image)(resources.GetObject("bnbFecharNota.Image")));
            this.bnbFecharNota.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnbFecharNota.Name = "bnbFecharNota";
            this.bnbFecharNota.Size = new System.Drawing.Size(23, 22);
            this.bnbFecharNota.Text = "Fechar Nota";
            // 
            // gbxDadosDaNota
            // 
            this.gbxDadosDaNota.Controls.Add(idnotadevendaLabel);
            this.gbxDadosDaNota.Controls.Add(this.idnotadevendaLabel1);
            this.gbxDadosDaNota.Controls.Add(idclienteLabel);
            this.gbxDadosDaNota.Controls.Add(this.idclienteComboBox);
            this.gbxDadosDaNota.Controls.Add(numerodanotaLabel);
            this.gbxDadosDaNota.Controls.Add(this.numerodanotaTextBox);
            this.gbxDadosDaNota.Controls.Add(datavendaLabel);
            this.gbxDadosDaNota.Controls.Add(this.datavendaDateTimePicker);
            this.gbxDadosDaNota.Controls.Add(notafechadaLabel);
            this.gbxDadosDaNota.Controls.Add(this.notafechadaLabel1);
            this.gbxDadosDaNota.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxDadosDaNota.Location = new System.Drawing.Point(0, 25);
            this.gbxDadosDaNota.Name = "gbxDadosDaNota";
            this.gbxDadosDaNota.Size = new System.Drawing.Size(456, 144);
            this.gbxDadosDaNota.TabIndex = 11;
            this.gbxDadosDaNota.TabStop = false;
            this.gbxDadosDaNota.Text = "Dados da nota";
            // 
            // idnotadevendaLabel1
            // 
            this.idnotadevendaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeVendaBindingSource, "idnotadevenda", true));
            this.idnotadevendaLabel1.Location = new System.Drawing.Point(142, 16);
            this.idnotadevendaLabel1.Name = "idnotadevendaLabel1";
            this.idnotadevendaLabel1.Size = new System.Drawing.Size(200, 23);
            this.idnotadevendaLabel1.TabIndex = 12;
            this.idnotadevendaLabel1.Text = "label1";
            // 
            // idclienteComboBox
            // 
            this.idclienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.notasDeVendaBindingSource, "idcliente", true));
            this.idclienteComboBox.DataSource = this.clientesBindingSource;
            this.idclienteComboBox.DisplayMember = "nome";
            this.idclienteComboBox.FormattingEnabled = true;
            this.idclienteComboBox.Location = new System.Drawing.Point(142, 42);
            this.idclienteComboBox.Name = "idclienteComboBox";
            this.idclienteComboBox.Size = new System.Drawing.Size(200, 21);
            this.idclienteComboBox.TabIndex = 14;
            this.idclienteComboBox.ValueMember = "idcliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // numerodanotaTextBox
            // 
            this.numerodanotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeVendaBindingSource, "numerodanota", true));
            this.numerodanotaTextBox.Location = new System.Drawing.Point(142, 69);
            this.numerodanotaTextBox.Name = "numerodanotaTextBox";
            this.numerodanotaTextBox.Size = new System.Drawing.Size(200, 20);
            this.numerodanotaTextBox.TabIndex = 16;
            // 
            // datavendaDateTimePicker
            // 
            this.datavendaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasDeVendaBindingSource, "datavenda", true));
            this.datavendaDateTimePicker.Location = new System.Drawing.Point(142, 95);
            this.datavendaDateTimePicker.Name = "datavendaDateTimePicker";
            this.datavendaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datavendaDateTimePicker.TabIndex = 18;
            // 
            // notafechadaLabel1
            // 
            this.notafechadaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeVendaBindingSource, "notafechada", true));
            this.notafechadaLabel1.Location = new System.Drawing.Point(142, 118);
            this.notafechadaLabel1.Name = "notafechadaLabel1";
            this.notafechadaLabel1.Size = new System.Drawing.Size(200, 23);
            this.notafechadaLabel1.TabIndex = 20;
            this.notafechadaLabel1.Text = "label1";
            // 
            // produtosNotaDeSaidaBindingSource
            // 
            this.produtosNotaDeSaidaBindingSource.DataMember = "FK_ProdutosNotaDeSaida_NotasDeVenda";
            this.produtosNotaDeSaidaBindingSource.DataSource = this.notasDeVendaBindingSource;
            // 
            // gbxProdutosDaNota
            // 
            this.gbxProdutosDaNota.Controls.Add(this.dgvProdutos);
            this.gbxProdutosDaNota.Controls.Add(this.bindingNavigator1);
            this.gbxProdutosDaNota.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxProdutosDaNota.Location = new System.Drawing.Point(0, 208);
            this.gbxProdutosDaNota.Name = "gbxProdutosDaNota";
            this.gbxProdutosDaNota.Size = new System.Drawing.Size(456, 194);
            this.gbxProdutosDaNota.TabIndex = 13;
            this.gbxProdutosDaNota.TabStop = false;
            this.gbxProdutosDaNota.Text = "Produtos da Nota";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvProdutos.DataSource = this.produtosNotaDeSaidaBindingSource;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 41);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(450, 150);
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precodevenda";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.notasDeVendaBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(450, 25);
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
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // FormNotaDeSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 402);
            this.Controls.Add(this.gbxProdutosDaNota);
            this.Controls.Add(this.gbxDadosDaNota);
            this.Controls.Add(this.notasDeVendaBindingNavigator);
            this.Name = "FormNotaDeSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nota De Saida";
            this.Load += new System.EventHandler(this.FormNotaDeSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingNavigator)).EndInit();
            this.notasDeVendaBindingNavigator.ResumeLayout(false);
            this.notasDeVendaBindingNavigator.PerformLayout();
            this.gbxDadosDaNota.ResumeLayout(false);
            this.gbxDadosDaNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeSaidaBindingSource)).EndInit();
            this.gbxProdutosDaNota.ResumeLayout(false);
            this.gbxProdutosDaNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.DSEstadosECidades dSEstadosECidades;
        private System.Windows.Forms.BindingSource notasDeVendaBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.NotasDeVendaTableAdapter notasDeVendaTableAdapter;
        private DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notasDeVendaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bnbAdd;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bnbRemove;
        private System.Windows.Forms.ToolStripButton bnbFirst;
        private System.Windows.Forms.ToolStripButton bnbPrior;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bnbRecordNo;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bnbNext;
        private System.Windows.Forms.ToolStripButton bnbLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bnbSave;
        private System.Windows.Forms.GroupBox gbxDadosDaNota;
        private System.Windows.Forms.Label idnotadevendaLabel1;
        private System.Windows.Forms.ComboBox idclienteComboBox;
        private System.Windows.Forms.TextBox numerodanotaTextBox;
        private System.Windows.Forms.DateTimePicker datavendaDateTimePicker;
        private System.Windows.Forms.Label notafechadaLabel1;
        private DataSets.DSEstadosECidadesTableAdapters.ProdutosNotaDeSaidaTableAdapter produtosNotaDeSaidaTableAdapter;
        private System.Windows.Forms.BindingSource produtosNotaDeSaidaBindingSource;
        private System.Windows.Forms.GroupBox gbxProdutosDaNota;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
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
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private DataSets.DSEstadosECidadesTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.ToolStripButton bnbEdit;
        private System.Windows.Forms.ToolStripButton bnbFecharNota;
    }
}