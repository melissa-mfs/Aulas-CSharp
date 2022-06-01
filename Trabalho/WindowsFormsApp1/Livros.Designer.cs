namespace WindowsFormsApp1
{
    partial class Livros
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
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.txteditora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodLivro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txttitulo
            // 
            this.txttitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.Location = new System.Drawing.Point(279, 165);
            this.txttitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(277, 41);
            this.txttitulo.TabIndex = 2;
            // 
            // txtautor
            // 
            this.txtautor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtautor.Location = new System.Drawing.Point(279, 223);
            this.txtautor.Margin = new System.Windows.Forms.Padding(4);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(277, 41);
            this.txtautor.TabIndex = 3;
            // 
            // txteditora
            // 
            this.txteditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteditora.Location = new System.Drawing.Point(279, 279);
            this.txteditora.Margin = new System.Windows.Forms.Padding(4);
            this.txteditora.Name = "txteditora";
            this.txteditora.Size = new System.Drawing.Size(277, 41);
            this.txteditora.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Título:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Editora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 46);
            this.label4.TabIndex = 9;
            this.label4.Text = "Livros";
            // 
            // btcadastrar
            // 
            this.btcadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.Location = new System.Drawing.Point(28, 378);
            this.btcadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(185, 49);
            this.btcadastrar.TabIndex = 10;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.Click += new System.EventHandler(this.Btcadastrar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.Location = new System.Drawing.Point(416, 378);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(185, 49);
            this.btcancelar.TabIndex = 11;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.Btcancelar_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.Location = new System.Drawing.Point(223, 378);
            this.btlimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(185, 49);
            this.btlimpar.TabIndex = 12;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.Btlimpar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "CodLivro";
            // 
            // txtCodLivro
            // 
            this.txtCodLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodLivro.Location = new System.Drawing.Point(279, 106);
            this.txtCodLivro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodLivro.Name = "txtCodLivro";
            this.txtCodLivro.Size = new System.Drawing.Size(277, 41);
            this.txtCodLivro.TabIndex = 13;
            // 
            // Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 473);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodLivro);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txteditora);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.txttitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Livros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.TextBox txteditora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodLivro;
    }
}