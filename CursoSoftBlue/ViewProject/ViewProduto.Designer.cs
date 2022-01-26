namespace ViewProject
{
    partial class ViewProduto
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
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.pnlSuperior.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.cmbProduto);
            this.pnlSuperior.Controls.Add(this.txtPrecoVenda);
            this.pnlSuperior.Controls.Add(this.txtDescricao);
            this.pnlSuperior.Controls.Add(this.txtEstoque);
            this.pnlSuperior.Controls.Add(this.txtCusto);
            this.pnlSuperior.Controls.Add(this.txtID);
            this.pnlSuperior.Controls.Add(this.label6);
            this.pnlSuperior.Controls.Add(this.label5);
            this.pnlSuperior.Controls.Add(this.label4);
            this.pnlSuperior.Controls.Add(this.label3);
            this.pnlSuperior.Controls.Add(this.label2);
            this.pnlSuperior.Controls.Add(this.label1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(485, 159);
            this.pnlSuperior.TabIndex = 1;
            // 
            // cmbProduto
            // 
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(107, 35);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(148, 21);
            this.cmbProduto.TabIndex = 2;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Enabled = false;
            this.txtPrecoVenda.Location = new System.Drawing.Point(107, 97);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(148, 20);
            this.txtPrecoVenda.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(281, 30);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(172, 119);
            this.txtDescricao.TabIndex = 1;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(107, 129);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(148, 20);
            this.txtEstoque.TabIndex = 1;
            // 
            // txtCusto
            // 
            this.txtCusto.Enabled = false;
            this.txtCusto.Location = new System.Drawing.Point(107, 64);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(148, 20);
            this.txtCusto.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(107, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(148, 20);
            this.txtID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Preço Venda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Estoque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Custo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.btnRemover);
            this.pnlInferior.Controls.Add(this.btnCancelar);
            this.pnlInferior.Controls.Add(this.btnSalvar);
            this.pnlInferior.Controls.Add(this.btnNovo);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 344);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(485, 67);
            this.pnlInferior.TabIndex = 2;
            // 
            // btnRemover
            // 
            this.btnRemover.Enabled = false;
            this.btnRemover.Location = new System.Drawing.Point(349, 21);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(82, 32);
            this.btnRemover.TabIndex = 0;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(249, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 32);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(149, 21);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 32);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(52, 21);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(82, 32);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduto.Location = new System.Drawing.Point(0, 159);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(485, 185);
            this.dgvProduto.TabIndex = 3;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            // 
            // ViewProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 411);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlSuperior);
            this.Name = "ViewProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewProduto";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label5;
    }
}