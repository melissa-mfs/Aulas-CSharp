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
            this.btnlimpar = new System.Windows.Forms.Button();
            this.lblcodcategoria = new System.Windows.Forms.Label();
            this.picimg = new System.Windows.Forms.PictureBox();
            this.btcores = new System.Windows.Forms.Button();
            this.btfonte = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.chococategoria = new System.Windows.Forms.ComboBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.txtimg = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btabririmg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).BeginInit();
            this.gb1.SuspendLayout();
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
            this.picimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picimg.TabIndex = 17;
            this.picimg.TabStop = false;
            // 
            // btcores
            // 
            this.btcores.Location = new System.Drawing.Point(648, 490);
            this.btcores.Name = "btcores";
            this.btcores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btcores.Size = new System.Drawing.Size(110, 39);
            this.btcores.TabIndex = 19;
            this.btcores.Text = "Cores";
            this.btcores.UseVisualStyleBackColor = true;
            this.btcores.Click += new System.EventHandler(this.Btcores_Click_1);
            // 
            // btfonte
            // 
            this.btfonte.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btfonte.Location = new System.Drawing.Point(648, 436);
            this.btfonte.Name = "btfonte";
            this.btfonte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btfonte.Size = new System.Drawing.Size(110, 39);
            this.btfonte.TabIndex = 19;
            this.btfonte.Text = "Fonte";
            this.btfonte.UseVisualStyleBackColor = true;
            this.btfonte.Click += new System.EventHandler(this.Btfonte_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.chococategoria);
            this.gb1.Controls.Add(this.txtano);
            this.gb1.Controls.Add(this.txtimg);
            this.gb1.Controls.Add(this.txtmodelo);
            this.gb1.Controls.Add(this.txtcor);
            this.gb1.Controls.Add(this.txtplaca);
            this.gb1.Controls.Add(this.txtmarca);
            this.gb1.Controls.Add(this.label7);
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gb1.Size = new System.Drawing.Size(420, 447);
            this.gb1.TabIndex = 20;
            this.gb1.TabStop = false;
            // 
            // chococategoria
            // 
            this.chococategoria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.chococategoria.FormattingEnabled = true;
            this.chococategoria.Location = new System.Drawing.Point(205, 388);
            this.chococategoria.Name = "chococategoria";
            this.chococategoria.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chococategoria.Size = new System.Drawing.Size(186, 30);
            this.chococategoria.TabIndex = 25;
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(205, 257);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(186, 30);
            this.txtano.TabIndex = 24;
            // 
            // txtimg
            // 
            this.txtimg.Location = new System.Drawing.Point(205, 321);
            this.txtimg.Name = "txtimg";
            this.txtimg.Size = new System.Drawing.Size(186, 30);
            this.txtimg.TabIndex = 23;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(205, 86);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(186, 30);
            this.txtmodelo.TabIndex = 22;
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(205, 138);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(186, 30);
            this.txtcor.TabIndex = 21;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(205, 202);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(186, 30);
            this.txtplaca.TabIndex = 20;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(205, 29);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(186, 30);
            this.txtmarca.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 329);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Imagem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Marca:";
            // 
            // btabririmg
            // 
            this.btabririmg.Location = new System.Drawing.Point(780, 436);
            this.btabririmg.Name = "btabririmg";
            this.btabririmg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btabririmg.Size = new System.Drawing.Size(110, 39);
            this.btabririmg.TabIndex = 21;
            this.btabririmg.Text = "Abrir";
            this.btabririmg.UseVisualStyleBackColor = true;
            this.btabririmg.Click += new System.EventHandler(this.Btabririmg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*|Imagens|*.jpg;*.png;*.gif;*.bmp ";
            // 
            // veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 594);
            this.Controls.Add(this.btabririmg);
            this.Controls.Add(this.btfonte);
            this.Controls.Add(this.btcores);
            this.Controls.Add(this.picimg);
            this.Controls.Add(this.lblcodcategoria);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.gb1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "veiculos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label lblcodcategoria;
        private System.Windows.Forms.PictureBox picimg;
        private System.Windows.Forms.Button btcores;
        private System.Windows.Forms.Button btfonte;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chococategoria;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.TextBox txtimg;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Button btabririmg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}