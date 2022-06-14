namespace Cadastro
{
    partial class automoveis
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
            this.lbldia = new System.Windows.Forms.Label();
            this.btcanc = new System.Windows.Forms.Button();
            this.txtdia = new System.Windows.Forms.TextBox();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblcat = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtcat = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.lblmensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldia.Location = new System.Drawing.Point(99, 163);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(148, 23);
            this.lbldia.TabIndex = 0;
            this.lbldia.Text = "Valor da Diária: ";
            // 
            // btcanc
            // 
            this.btcanc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcanc.Location = new System.Drawing.Point(338, 266);
            this.btcanc.Name = "btcanc";
            this.btcanc.Size = new System.Drawing.Size(202, 37);
            this.btcanc.TabIndex = 1;
            this.btcanc.Text = "Cancelar";
            this.btcanc.UseVisualStyleBackColor = true;
            // 
            // txtdia
            // 
            this.txtdia.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdia.Location = new System.Drawing.Point(338, 163);
            this.txtdia.Name = "txtdia";
            this.txtdia.Size = new System.Drawing.Size(202, 32);
            this.txtdia.TabIndex = 2;
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(148, 103);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(99, 23);
            this.lbldesc.TabIndex = 0;
            this.lbldesc.Text = "Descrição:";
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcat.Location = new System.Drawing.Point(150, 43);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(97, 23);
            this.lblcat.TabIndex = 0;
            this.lblcat.Text = "Categoria:";
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(338, 94);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(202, 32);
            this.txtdesc.TabIndex = 2;
            // 
            // txtcat
            // 
            this.txtcat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcat.Location = new System.Drawing.Point(338, 34);
            this.txtcat.Name = "txtcat";
            this.txtcat.Size = new System.Drawing.Size(202, 32);
            this.txtcat.TabIndex = 2;
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(103, 266);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(202, 37);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Cadastrar";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblmensagem
            // 
            this.lblmensagem.AutoSize = true;
            this.lblmensagem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensagem.Location = new System.Drawing.Point(288, 366);
            this.lblmensagem.Name = "lblmensagem";
            this.lblmensagem.Size = new System.Drawing.Size(65, 23);
            this.lblmensagem.TabIndex = 0;
            this.lblmensagem.Text = "_____";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.txtcat);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtdia);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.btcanc);
            this.Controls.Add(this.lblcat);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.lblmensagem);
            this.Controls.Add(this.lbldia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldia;
        private System.Windows.Forms.Button btcanc;
        private System.Windows.Forms.TextBox txtdia;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lblcat;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtcat;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Label lblmensagem;
    }
}

