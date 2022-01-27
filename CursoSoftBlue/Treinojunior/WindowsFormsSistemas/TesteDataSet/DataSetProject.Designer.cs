namespace Treinojunior.WindowsFormsSistemas.TesteDataSet
{
    partial class DataSetProject
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnControle = new System.Windows.Forms.Button();
            this.tcResultados = new System.Windows.Forms.TabControl();
            this.tpgXML = new System.Windows.Forms.TabPage();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.tpgComboEGrid = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxEstados = new System.Windows.Forms.ComboBox();
            this.dgvCidades = new System.Windows.Forms.DataGridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.pnlSuperior.SuspendLayout();
            this.tcResultados.SuspendLayout();
            this.tpgXML.SuspendLayout();
            this.tpgComboEGrid.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSuperior.Controls.Add(this.btnControle);
            this.pnlSuperior.Controls.Add(this.btnVisualizar);
            this.pnlSuperior.Controls.Add(this.btnInserir);
            this.pnlSuperior.Controls.Add(this.btnCriar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(429, 47);
            this.pnlSuperior.TabIndex = 0;
            // 
            // btnCriar
            // 
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Location = new System.Drawing.Point(16, 12);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(96, 23);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "Criar DataSet";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(118, 12);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(96, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir Dados";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(220, 12);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(96, 23);
            this.btnVisualizar.TabIndex = 0;
            this.btnVisualizar.Text = "Visualizar XML";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnControle
            // 
            this.btnControle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControle.Location = new System.Drawing.Point(322, 12);
            this.btnControle.Name = "btnControle";
            this.btnControle.Size = new System.Drawing.Size(96, 23);
            this.btnControle.TabIndex = 0;
            this.btnControle.Text = "Controles Visuais";
            this.btnControle.UseVisualStyleBackColor = true;
            this.btnControle.Click += new System.EventHandler(this.btnControle_Click);
            // 
            // tcResultados
            // 
            this.tcResultados.Controls.Add(this.tpgXML);
            this.tcResultados.Controls.Add(this.tpgComboEGrid);
            this.tcResultados.Location = new System.Drawing.Point(0, 53);
            this.tcResultados.Name = "tcResultados";
            this.tcResultados.SelectedIndex = 0;
            this.tcResultados.Size = new System.Drawing.Size(426, 190);
            this.tcResultados.TabIndex = 5;
            // 
            // tpgXML
            // 
            this.tpgXML.Controls.Add(this.txtXML);
            this.tpgXML.Location = new System.Drawing.Point(4, 22);
            this.tpgXML.Name = "tpgXML";
            this.tpgXML.Padding = new System.Windows.Forms.Padding(3);
            this.tpgXML.Size = new System.Drawing.Size(418, 164);
            this.tpgXML.TabIndex = 0;
            this.tpgXML.Text = "Dados em XML";
            this.tpgXML.UseVisualStyleBackColor = true;
            // 
            // txtXML
            // 
            this.txtXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXML.Location = new System.Drawing.Point(3, 3);
            this.txtXML.Multiline = true;
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(412, 158);
            this.txtXML.TabIndex = 0;
            // 
            // tpgComboEGrid
            // 
            this.tpgComboEGrid.Controls.Add(this.tableLayoutPanel1);
            this.tpgComboEGrid.Location = new System.Drawing.Point(4, 22);
            this.tpgComboEGrid.Name = "tpgComboEGrid";
            this.tpgComboEGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tpgComboEGrid.Size = new System.Drawing.Size(418, 164);
            this.tpgComboEGrid.TabIndex = 1;
            this.tpgComboEGrid.Text = "Dados em Controles";
            this.tpgComboEGrid.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cbxEstados, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvCidades, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEstado, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 158);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // cbxEstados
            // 
            this.cbxEstados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEstados.FormattingEnabled = true;
            this.cbxEstados.Location = new System.Drawing.Point(52, 3);
            this.cbxEstados.Name = "cbxEstados";
            this.cbxEstados.Size = new System.Drawing.Size(357, 21);
            this.cbxEstados.TabIndex = 1;
            // 
            // dgvCidades
            // 
            this.dgvCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvCidades, 2);
            this.dgvCidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCidades.Location = new System.Drawing.Point(3, 30);
            this.dgvCidades.Name = "dgvCidades";
            this.dgvCidades.Size = new System.Drawing.Size(406, 125);
            this.dgvCidades.TabIndex = 2;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(3, 7);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado:";
            // 
            // DataSetProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 287);
            this.Controls.Add(this.tcResultados);
            this.Controls.Add(this.pnlSuperior);
            this.Name = "DataSetProject";
            this.Text = "DataSetProject";
            this.pnlSuperior.ResumeLayout(false);
            this.tcResultados.ResumeLayout(false);
            this.tpgXML.ResumeLayout(false);
            this.tpgXML.PerformLayout();
            this.tpgComboEGrid.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnControle;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TabControl tcResultados;
        private System.Windows.Forms.TabPage tpgXML;
        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.TabPage tpgComboEGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbxEstados;
        private System.Windows.Forms.DataGridView dgvCidades;
        private System.Windows.Forms.Label lblEstado;
    }
}