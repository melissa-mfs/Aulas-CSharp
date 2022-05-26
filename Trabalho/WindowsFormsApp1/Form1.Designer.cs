namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rbtamigos = new System.Windows.Forms.RadioButton();
            this.rbtemprestimos = new System.Windows.Forms.RadioButton();
            this.rbtlivros = new System.Windows.Forms.RadioButton();
            this.btavancar = new System.Windows.Forms.Button();
            this.rbtemplivro = new System.Windows.Forms.RadioButton();
            this.rbtretirada = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rbtamigos
            // 
            this.rbtamigos.AutoSize = true;
            this.rbtamigos.Checked = true;
            this.rbtamigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtamigos.Location = new System.Drawing.Point(215, 158);
            this.rbtamigos.Name = "rbtamigos";
            this.rbtamigos.Size = new System.Drawing.Size(128, 35);
            this.rbtamigos.TabIndex = 5;
            this.rbtamigos.TabStop = true;
            this.rbtamigos.Text = "Amigos";
            this.rbtamigos.UseVisualStyleBackColor = true;
            this.rbtamigos.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rbtemprestimos
            // 
            this.rbtemprestimos.AutoSize = true;
            this.rbtemprestimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtemprestimos.Location = new System.Drawing.Point(215, 204);
            this.rbtemprestimos.Name = "rbtemprestimos";
            this.rbtemprestimos.Size = new System.Drawing.Size(201, 35);
            this.rbtemprestimos.TabIndex = 6;
            this.rbtemprestimos.Text = "Empréstimos";
            this.rbtemprestimos.UseVisualStyleBackColor = true;
            // 
            // rbtlivros
            // 
            this.rbtlivros.AutoSize = true;
            this.rbtlivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtlivros.Location = new System.Drawing.Point(215, 242);
            this.rbtlivros.Name = "rbtlivros";
            this.rbtlivros.Size = new System.Drawing.Size(111, 35);
            this.rbtlivros.TabIndex = 7;
            this.rbtlivros.Text = "Livros";
            this.rbtlivros.UseVisualStyleBackColor = true;
            // 
            // btavancar
            // 
            this.btavancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btavancar.Location = new System.Drawing.Point(493, 433);
            this.btavancar.Name = "btavancar";
            this.btavancar.Size = new System.Drawing.Size(211, 73);
            this.btavancar.TabIndex = 10;
            this.btavancar.Text = "Avançar";
            this.btavancar.UseVisualStyleBackColor = true;
            this.btavancar.Click += new System.EventHandler(this.Btavancar_Click);
            // 
            // rbtemplivro
            // 
            this.rbtemplivro.AutoSize = true;
            this.rbtemplivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtemplivro.Location = new System.Drawing.Point(740, 158);
            this.rbtemplivro.Name = "rbtemplivro";
            this.rbtemplivro.Size = new System.Drawing.Size(299, 35);
            this.rbtemplivro.TabIndex = 8;
            this.rbtemplivro.Text = "Empréstimo por livro";
            this.rbtemplivro.UseVisualStyleBackColor = true;
            // 
            // rbtretirada
            // 
            this.rbtretirada.AutoSize = true;
            this.rbtretirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtretirada.Location = new System.Drawing.Point(740, 204);
            this.rbtretirada.Name = "rbtretirada";
            this.rbtretirada.Size = new System.Drawing.Size(409, 35);
            this.rbtretirada.TabIndex = 9;
            this.rbtretirada.Text = "Empréstimo por data retirada";
            this.rbtretirada.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastrar";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(740, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Consultar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 569);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btavancar);
            this.Controls.Add(this.rbtretirada);
            this.Controls.Add(this.rbtemplivro);
            this.Controls.Add(this.rbtlivros);
            this.Controls.Add(this.rbtemprestimos);
            this.Controls.Add(this.rbtamigos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RadioButton rbtamigos;
        private System.Windows.Forms.RadioButton rbtemprestimos;
        private System.Windows.Forms.RadioButton rbtlivros;
        private System.Windows.Forms.Button btavancar;
        private System.Windows.Forms.RadioButton rbtemplivro;
        private System.Windows.Forms.RadioButton rbtretirada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

