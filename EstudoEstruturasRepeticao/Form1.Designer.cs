namespace EstudoEstruturasRepeticao
{
    partial class frmEstruturasRepeticao
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lsbResultados = new System.Windows.Forms.ListBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um número:";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(110, 6);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(31, 20);
            this.txbNumero.TabIndex = 1;
            this.txbNumero.TextChanged += new System.EventHandler(this.txbNumero_TextChanged);
            // 
            // lsbResultados
            // 
            this.lsbResultados.FormattingEnabled = true;
            this.lsbResultados.Location = new System.Drawing.Point(156, 6);
            this.lsbResultados.Name = "lsbResultados";
            this.lsbResultados.Size = new System.Drawing.Size(120, 121);
            this.lsbResultados.TabIndex = 2;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(29, 44);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 3;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // frmEstruturasRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 158);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.lsbResultados);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.label1);
            this.Name = "frmEstruturasRepeticao";
            this.Text = "TreinaWeb - Estruturas de Repetição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.ListBox lsbResultados;
        private System.Windows.Forms.Button btnCalcula;
    }
}

