namespace VARIOSFORMULARIOS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInserir = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.textBoxMultiTexto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInserir
            // 
            this.textBoxInserir.Location = new System.Drawing.Point(51, 50);
            this.textBoxInserir.Name = "textBoxInserir";
            this.textBoxInserir.Size = new System.Drawing.Size(304, 20);
            this.textBoxInserir.TabIndex = 0;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(529, 50);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // textBoxMultiTexto
            // 
            this.textBoxMultiTexto.Location = new System.Drawing.Point(51, 111);
            this.textBoxMultiTexto.Multiline = true;
            this.textBoxMultiTexto.Name = "textBoxMultiTexto";
            this.textBoxMultiTexto.Size = new System.Drawing.Size(304, 263);
            this.textBoxMultiTexto.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "LIMPAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxMultiTexto);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.textBoxInserir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInserir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox textBoxMultiTexto;
        private System.Windows.Forms.Button button2;
    }
}

