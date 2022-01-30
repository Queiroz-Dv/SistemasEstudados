namespace Treinojunior.WindowsFormsSistemas.DataSetTipado
{
    partial class MenuDataSetTipado
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
            this.btnEstados = new System.Windows.Forms.Button();
            this.btnCidades = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnNotasDeEntrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstados
            // 
            this.btnEstados.Location = new System.Drawing.Point(52, 12);
            this.btnEstados.Name = "btnEstados";
            this.btnEstados.Size = new System.Drawing.Size(93, 89);
            this.btnEstados.TabIndex = 0;
            this.btnEstados.Text = "Estados";
            this.btnEstados.UseVisualStyleBackColor = true;
            this.btnEstados.Click += new System.EventHandler(this.btnEstados_Click);
            // 
            // btnCidades
            // 
            this.btnCidades.Location = new System.Drawing.Point(171, 12);
            this.btnCidades.Name = "btnCidades";
            this.btnCidades.Size = new System.Drawing.Size(93, 89);
            this.btnCidades.TabIndex = 0;
            this.btnCidades.Text = "Cidades";
            this.btnCidades.UseVisualStyleBackColor = true;
            this.btnCidades.Click += new System.EventHandler(this.btnCidades_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Location = new System.Drawing.Point(284, 12);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(93, 89);
            this.btnFornecedores.TabIndex = 0;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(171, 107);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(93, 89);
            this.btnProdutos.TabIndex = 0;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnNotasDeEntrada
            // 
            this.btnNotasDeEntrada.Location = new System.Drawing.Point(284, 107);
            this.btnNotasDeEntrada.Name = "btnNotasDeEntrada";
            this.btnNotasDeEntrada.Size = new System.Drawing.Size(93, 89);
            this.btnNotasDeEntrada.TabIndex = 0;
            this.btnNotasDeEntrada.Text = "Notas de Entrada";
            this.btnNotasDeEntrada.UseVisualStyleBackColor = true;
            this.btnNotasDeEntrada.Click += new System.EventHandler(this.btnNotasDeEntrada_Click);
            // 
            // MenuDataSetTipado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 198);
            this.Controls.Add(this.btnNotasDeEntrada);
            this.Controls.Add(this.btnFornecedores);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnCidades);
            this.Controls.Add(this.btnEstados);
            this.Name = "MenuDataSetTipado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Set Tipado ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstados;
        private System.Windows.Forms.Button btnCidades;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnNotasDeEntrada;
    }
}