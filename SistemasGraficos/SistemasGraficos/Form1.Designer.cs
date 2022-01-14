namespace SistemasGraficos
{
    partial class frmGastoRestaurante
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
            this.btnDividir = new System.Windows.Forms.Button();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalDaConta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(152, 8);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(55, 23);
            this.btnDividir.TabIndex = 1;
            this.btnDividir.Text = "Calcular";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // txtDespesa
            // 
            this.txtDespesa.Location = new System.Drawing.Point(76, 10);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(70, 20);
            this.txtDespesa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Despesa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total com 10% :";
            // 
            // txtTotalDaConta
            // 
            this.txtTotalDaConta.Location = new System.Drawing.Point(112, 37);
            this.txtTotalDaConta.Name = "txtTotalDaConta";
            this.txtTotalDaConta.ReadOnly = true;
            this.txtTotalDaConta.Size = new System.Drawing.Size(91, 20);
            this.txtTotalDaConta.TabIndex = 2;
            // 
            // frmGastoRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 61);
            this.Controls.Add(this.txtDespesa);
            this.Controls.Add(this.txtTotalDaConta);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "frmGastoRestaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gasto em Restaurante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalDaConta;
    }
}

