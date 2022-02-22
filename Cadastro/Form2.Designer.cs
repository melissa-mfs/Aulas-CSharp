namespace Cadastro
{
    partial class Form2
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
            this.lblcli = new System.Windows.Forms.Label();
            this.txtcli = new System.Windows.Forms.TextBox();
            this.btcad = new System.Windows.Forms.Button();
            this.lblend = new System.Windows.Forms.Label();
            this.txtend = new System.Windows.Forms.TextBox();
            this.lblbai = new System.Windows.Forms.Label();
            this.txtbai = new System.Windows.Forms.TextBox();
            this.lblcid = new System.Windows.Forms.Label();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.lblest = new System.Windows.Forms.Label();
            this.txtest = new System.Windows.Forms.TextBox();
            this.lblpai = new System.Windows.Forms.Label();
            this.txtpai = new System.Windows.Forms.TextBox();
            this.lblnasc = new System.Windows.Forms.Label();
            this.txtnasc = new System.Windows.Forms.TextBox();
            this.lblcnh = new System.Windows.Forms.Label();
            this.txtcnh = new System.Windows.Forms.TextBox();
            this.btlimp = new System.Windows.Forms.Button();
            this.lblmensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcli
            // 
            this.lblcli.AutoSize = true;
            this.lblcli.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcli.Location = new System.Drawing.Point(69, 29);
            this.lblcli.Name = "lblcli";
            this.lblcli.Size = new System.Drawing.Size(62, 19);
            this.lblcli.TabIndex = 0;
            this.lblcli.Text = "Cliente:";
            // 
            // txtcli
            // 
            this.txtcli.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcli.Location = new System.Drawing.Point(251, 21);
            this.txtcli.Name = "txtcli";
            this.txtcli.Size = new System.Drawing.Size(231, 26);
            this.txtcli.TabIndex = 1;
            // 
            // btcad
            // 
            this.btcad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcad.Location = new System.Drawing.Point(58, 462);
            this.btcad.Name = "btcad";
            this.btcad.Size = new System.Drawing.Size(147, 44);
            this.btcad.TabIndex = 2;
            this.btcad.Text = "Cadastrar";
            this.btcad.UseVisualStyleBackColor = true;
            this.btcad.Click += new System.EventHandler(this.Btcad_Click);
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblend.Location = new System.Drawing.Point(69, 82);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(77, 19);
            this.lblend.TabIndex = 0;
            this.lblend.Text = "Endereço:";
            // 
            // txtend
            // 
            this.txtend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtend.Location = new System.Drawing.Point(251, 74);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(231, 26);
            this.txtend.TabIndex = 1;
            this.txtend.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // lblbai
            // 
            this.lblbai.AutoSize = true;
            this.lblbai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbai.Location = new System.Drawing.Point(69, 127);
            this.lblbai.Name = "lblbai";
            this.lblbai.Size = new System.Drawing.Size(52, 19);
            this.lblbai.TabIndex = 0;
            this.lblbai.Text = "Bairro";
            // 
            // txtbai
            // 
            this.txtbai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbai.Location = new System.Drawing.Point(251, 119);
            this.txtbai.Name = "txtbai";
            this.txtbai.Size = new System.Drawing.Size(231, 26);
            this.txtbai.TabIndex = 1;
            // 
            // lblcid
            // 
            this.lblcid.AutoSize = true;
            this.lblcid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcid.Location = new System.Drawing.Point(69, 179);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(61, 19);
            this.lblcid.TabIndex = 0;
            this.lblcid.Text = "Cidade:";
            // 
            // txtcid
            // 
            this.txtcid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid.Location = new System.Drawing.Point(251, 171);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(231, 26);
            this.txtcid.TabIndex = 1;
            // 
            // lblest
            // 
            this.lblest.AutoSize = true;
            this.lblest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblest.Location = new System.Drawing.Point(69, 229);
            this.lblest.Name = "lblest";
            this.lblest.Size = new System.Drawing.Size(60, 19);
            this.lblest.TabIndex = 0;
            this.lblest.Text = "Estado:";
            // 
            // txtest
            // 
            this.txtest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtest.Location = new System.Drawing.Point(251, 221);
            this.txtest.Name = "txtest";
            this.txtest.Size = new System.Drawing.Size(231, 26);
            this.txtest.TabIndex = 1;
            // 
            // lblpai
            // 
            this.lblpai.AutoSize = true;
            this.lblpai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpai.Location = new System.Drawing.Point(69, 281);
            this.lblpai.Name = "lblpai";
            this.lblpai.Size = new System.Drawing.Size(46, 19);
            this.lblpai.TabIndex = 0;
            this.lblpai.Text = "Pais: ";
            // 
            // txtpai
            // 
            this.txtpai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpai.Location = new System.Drawing.Point(251, 273);
            this.txtpai.Name = "txtpai";
            this.txtpai.Size = new System.Drawing.Size(231, 26);
            this.txtpai.TabIndex = 1;
            // 
            // lblnasc
            // 
            this.lblnasc.AutoSize = true;
            this.lblnasc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnasc.Location = new System.Drawing.Point(69, 338);
            this.lblnasc.Name = "lblnasc";
            this.lblnasc.Size = new System.Drawing.Size(105, 19);
            this.lblnasc.TabIndex = 0;
            this.lblnasc.Text = "Data de Nasc:";
            // 
            // txtnasc
            // 
            this.txtnasc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnasc.Location = new System.Drawing.Point(251, 330);
            this.txtnasc.Name = "txtnasc";
            this.txtnasc.Size = new System.Drawing.Size(231, 26);
            this.txtnasc.TabIndex = 1;
            // 
            // lblcnh
            // 
            this.lblcnh.AutoSize = true;
            this.lblcnh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcnh.Location = new System.Drawing.Point(69, 391);
            this.lblcnh.Name = "lblcnh";
            this.lblcnh.Size = new System.Drawing.Size(49, 19);
            this.lblcnh.TabIndex = 0;
            this.lblcnh.Text = "CNH:";
            // 
            // txtcnh
            // 
            this.txtcnh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnh.Location = new System.Drawing.Point(251, 383);
            this.txtcnh.Name = "txtcnh";
            this.txtcnh.Size = new System.Drawing.Size(231, 26);
            this.txtcnh.TabIndex = 1;
            // 
            // btlimp
            // 
            this.btlimp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimp.Location = new System.Drawing.Point(335, 462);
            this.btlimp.Name = "btlimp";
            this.btlimp.Size = new System.Drawing.Size(147, 44);
            this.btlimp.TabIndex = 2;
            this.btlimp.Text = "Limpar";
            this.btlimp.UseVisualStyleBackColor = true;
            // 
            // lblmensagem
            // 
            this.lblmensagem.AutoSize = true;
            this.lblmensagem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensagem.Location = new System.Drawing.Point(131, 529);
            this.lblmensagem.Name = "lblmensagem";
            this.lblmensagem.Size = new System.Drawing.Size(25, 24);
            this.lblmensagem.TabIndex = 0;
            this.lblmensagem.Text = "...";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 571);
            this.Controls.Add(this.btlimp);
            this.Controls.Add(this.btcad);
            this.Controls.Add(this.txtcnh);
            this.Controls.Add(this.txtnasc);
            this.Controls.Add(this.txtpai);
            this.Controls.Add(this.txtest);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.txtbai);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.txtcli);
            this.Controls.Add(this.lblmensagem);
            this.Controls.Add(this.lblcnh);
            this.Controls.Add(this.lblnasc);
            this.Controls.Add(this.lblpai);
            this.Controls.Add(this.lblest);
            this.Controls.Add(this.lblcid);
            this.Controls.Add(this.lblbai);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.lblcli);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcli;
        private System.Windows.Forms.TextBox txtcli;
        private System.Windows.Forms.Button btcad;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.Label lblbai;
        private System.Windows.Forms.TextBox txtbai;
        private System.Windows.Forms.Label lblcid;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Label lblest;
        private System.Windows.Forms.TextBox txtest;
        private System.Windows.Forms.Label lblpai;
        private System.Windows.Forms.TextBox txtpai;
        private System.Windows.Forms.Label lblnasc;
        private System.Windows.Forms.TextBox txtnasc;
        private System.Windows.Forms.Label lblcnh;
        private System.Windows.Forms.TextBox txtcnh;
        private System.Windows.Forms.Button btlimp;
        private System.Windows.Forms.Label lblmensagem;
    }
}