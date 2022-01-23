namespace ViewProject
{
    partial class ViewNotaEntrada
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
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvNota = new System.Windows.Forms.DataGridView();
            this.pnlSuperior.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.dtpEntrada);
            this.pnlSuperior.Controls.Add(this.dtpEmissao);
            this.pnlSuperior.Controls.Add(this.cmbFornecedor);
            this.pnlSuperior.Controls.Add(this.txtNumero);
            this.pnlSuperior.Controls.Add(this.txtID);
            this.pnlSuperior.Controls.Add(this.label5);
            this.pnlSuperior.Controls.Add(this.label4);
            this.pnlSuperior.Controls.Add(this.label3);
            this.pnlSuperior.Controls.Add(this.label2);
            this.pnlSuperior.Controls.Add(this.label1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(485, 96);
            this.pnlSuperior.TabIndex = 0;
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(346, 39);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(127, 20);
            this.dtpEntrada.TabIndex = 3;
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.Location = new System.Drawing.Point(346, 13);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(127, 20);
            this.dtpEmissao.TabIndex = 3;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(103, 35);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(145, 21);
            this.cmbFornecedor.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(103, 64);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(145, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(103, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(145, 20);
            this.txtID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Entrada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Emissão:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fornecedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.btnVoltar);
            this.pnlInferior.Controls.Add(this.btnRemover);
            this.pnlInferior.Controls.Add(this.btnCancelar);
            this.pnlInferior.Controls.Add(this.btnSalvar);
            this.pnlInferior.Controls.Add(this.btnNovo);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 348);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(485, 63);
            this.pnlInferior.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(377, 21);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(82, 32);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(289, 21);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(82, 32);
            this.btnRemover.TabIndex = 0;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(201, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 32);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(113, 21);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 32);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(25, 21);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(82, 32);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvNota
            // 
            this.dgvNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNota.Location = new System.Drawing.Point(0, 96);
            this.dgvNota.Name = "dgvNota";
            this.dgvNota.Size = new System.Drawing.Size(485, 252);
            this.dgvNota.TabIndex = 2;
            this.dgvNota.SelectionChanged += new System.EventHandler(this.dgvNota_SelectionChanged);
            // 
            // ViewNotaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 411);
            this.Controls.Add(this.dgvNota);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlSuperior);
            this.Name = "ViewNotaEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Nota de Entrada";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvNota;
    }
}