namespace Treinojunior.WindowsFormsSistemas.DataSetTipado
{
    partial class DataSetTipadoProject
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
            this.SuspendLayout();
            // 
            // btnEstados
            // 
            this.btnEstados.Location = new System.Drawing.Point(82, 80);
            this.btnEstados.Name = "btnEstados";
            this.btnEstados.Size = new System.Drawing.Size(93, 89);
            this.btnEstados.TabIndex = 0;
            this.btnEstados.Text = "Estados DataSet";
            this.btnEstados.UseVisualStyleBackColor = true;
            this.btnEstados.Click += new System.EventHandler(this.btnEstados_Click);
            // 
            // btnCidades
            // 
            this.btnCidades.Location = new System.Drawing.Point(244, 80);
            this.btnCidades.Name = "btnCidades";
            this.btnCidades.Size = new System.Drawing.Size(93, 89);
            this.btnCidades.TabIndex = 0;
            this.btnCidades.Text = "Cidades DataSet";
            this.btnCidades.UseVisualStyleBackColor = true;
            this.btnCidades.Click += new System.EventHandler(this.btnCidades_Click);
            // 
            // DataSetTipadoProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 198);
            this.Controls.Add(this.btnCidades);
            this.Controls.Add(this.btnEstados);
            this.Name = "DataSetTipadoProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Set Tipado ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstados;
        private System.Windows.Forms.Button btnCidades;
    }
}