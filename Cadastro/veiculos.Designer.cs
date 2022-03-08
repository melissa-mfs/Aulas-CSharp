namespace Cadastro
{
    partial class veiculos
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
            this.btncadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtimg = new System.Windows.Forms.TextBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.lblcodcategoria = new System.Windows.Forms.Label();
            this.picimg = new System.Windows.Forms.PictureBox();
            this.chococategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).BeginInit();
            this.SuspendLayout();
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(143, 490);
            this.btncadastrar.Margin = new System.Windows.Forms.Padding(5);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(125, 39);
            this.btncadastrar.TabIndex = 0;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.Btncadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Placa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ano:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Imagem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 394);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Categoria";
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(386, 490);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnlimpar.Size = new System.Drawing.Size(110, 39);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(198, 27);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(186, 30);
            this.txtmarca.TabIndex = 9;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(198, 200);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(186, 30);
            this.txtplaca.TabIndex = 10;
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(198, 136);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(186, 30);
            this.txtcor.TabIndex = 11;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(198, 84);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(186, 30);
            this.txtmodelo.TabIndex = 12;
            // 
            // txtimg
            // 
            this.txtimg.Location = new System.Drawing.Point(198, 319);
            this.txtimg.Name = "txtimg";
            this.txtimg.Size = new System.Drawing.Size(186, 30);
            this.txtimg.TabIndex = 13;
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(198, 255);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(186, 30);
            this.txtano.TabIndex = 14;
            // 
            // lblcodcategoria
            // 
            this.lblcodcategoria.AutoSize = true;
            this.lblcodcategoria.Location = new System.Drawing.Point(510, 399);
            this.lblcodcategoria.Name = "lblcodcategoria";
            this.lblcodcategoria.Size = new System.Drawing.Size(40, 22);
            this.lblcodcategoria.TabIndex = 16;
            this.lblcodcategoria.Text = "...";
            // 
            // picimg
            // 
            this.picimg.Location = new System.Drawing.Point(514, 37);
            this.picimg.Name = "picimg";
            this.picimg.Size = new System.Drawing.Size(376, 336);
            this.picimg.TabIndex = 17;
            this.picimg.TabStop = false;
            // 
            // chococategoria
            // 
            this.chococategoria.FormattingEnabled = true;
            this.chococategoria.Location = new System.Drawing.Point(198, 386);
            this.chococategoria.Name = "chococategoria";
            this.chococategoria.Size = new System.Drawing.Size(186, 30);
            this.chococategoria.TabIndex = 18;
            this.chococategoria.SelectedIndexChanged += new System.EventHandler(this.Chococategoria_SelectedIndexChanged);
            // 
            // veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 594);
            this.Controls.Add(this.chococategoria);
            this.Controls.Add(this.picimg);
            this.Controls.Add(this.lblcodcategoria);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.txtimg);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncadastrar);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "veiculos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtimg;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.Label lblcodcategoria;
        private System.Windows.Forms.PictureBox picimg;
        private System.Windows.Forms.ComboBox chococategoria;
    }
}