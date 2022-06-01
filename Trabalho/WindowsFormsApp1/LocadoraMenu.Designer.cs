namespace WindowsFormsApp1
{
    partial class LocadoraMenu
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
            this.rbtamigos = new System.Windows.Forms.RadioButton();
            this.rbtemprestimos = new System.Windows.Forms.RadioButton();
            this.rbtlivros = new System.Windows.Forms.RadioButton();
            this.btavancar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtamigos
            // 
            this.rbtamigos.AutoSize = true;
            this.rbtamigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtamigos.Location = new System.Drawing.Point(133, 119);
            this.rbtamigos.Margin = new System.Windows.Forms.Padding(4);
            this.rbtamigos.Name = "rbtamigos";
            this.rbtamigos.Size = new System.Drawing.Size(142, 40);
            this.rbtamigos.TabIndex = 5;
            this.rbtamigos.Text = "Amigos";
            this.rbtamigos.UseVisualStyleBackColor = true;
            // 
            // rbtemprestimos
            // 
            this.rbtemprestimos.AutoSize = true;
            this.rbtemprestimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtemprestimos.Location = new System.Drawing.Point(133, 235);
            this.rbtemprestimos.Margin = new System.Windows.Forms.Padding(4);
            this.rbtemprestimos.Name = "rbtemprestimos";
            this.rbtemprestimos.Size = new System.Drawing.Size(218, 40);
            this.rbtemprestimos.TabIndex = 6;
            this.rbtemprestimos.Text = "Empréstimos";
            this.rbtemprestimos.UseVisualStyleBackColor = true;
            // 
            // rbtlivros
            // 
            this.rbtlivros.AutoSize = true;
            this.rbtlivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtlivros.Location = new System.Drawing.Point(133, 178);
            this.rbtlivros.Margin = new System.Windows.Forms.Padding(4);
            this.rbtlivros.Name = "rbtlivros";
            this.rbtlivros.Size = new System.Drawing.Size(123, 40);
            this.rbtlivros.TabIndex = 7;
            this.rbtlivros.Text = "Livros";
            this.rbtlivros.UseVisualStyleBackColor = true;
            // 
            // btavancar
            // 
            this.btavancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btavancar.Location = new System.Drawing.Point(133, 347);
            this.btavancar.Margin = new System.Windows.Forms.Padding(4);
            this.btavancar.Name = "btavancar";
            this.btavancar.Size = new System.Drawing.Size(185, 49);
            this.btavancar.TabIndex = 10;
            this.btavancar.Text = "Avançar";
            this.btavancar.UseVisualStyleBackColor = true;
            this.btavancar.Click += new System.EventHandler(this.Btavancar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastrar";
            // 
            // LocadoraMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btavancar);
            this.Controls.Add(this.rbtlivros);
            this.Controls.Add(this.rbtemprestimos);
            this.Controls.Add(this.rbtamigos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LocadoraMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtamigos;
        private System.Windows.Forms.RadioButton rbtemprestimos;
        private System.Windows.Forms.RadioButton rbtlivros;
        private System.Windows.Forms.Button btavancar;
        private System.Windows.Forms.Label label1;
    }
}

