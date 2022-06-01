namespace WindowsFormsApp1
{
    partial class Amigos
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
            this.lblnome = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.lblbairro = new System.Windows.Forms.Label();
            this.lblcid = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtend = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodAmigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amigos";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(54, 174);
            this.lblnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(106, 36);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome:";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblend.Location = new System.Drawing.Point(54, 224);
            this.lblend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(160, 36);
            this.lblend.TabIndex = 2;
            this.lblend.Text = "Endereço:";
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbairro.Location = new System.Drawing.Point(53, 271);
            this.lblbairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(110, 36);
            this.lblbairro.TabIndex = 3;
            this.lblbairro.Text = "Bairro:";
            // 
            // lblcid
            // 
            this.lblcid.AutoSize = true;
            this.lblcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcid.Location = new System.Drawing.Point(54, 322);
            this.lblcid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(124, 36);
            this.lblcid.TabIndex = 4;
            this.lblcid.Text = "Cidade:";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.Location = new System.Drawing.Point(54, 372);
            this.lbltel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(147, 36);
            this.lbltel.TabIndex = 5;
            this.lbltel.Text = "Telefone:";
            // 
            // btcadastrar
            // 
            this.btcadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.Location = new System.Drawing.Point(40, 476);
            this.btcadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(185, 49);
            this.btcadastrar.TabIndex = 6;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.Click += new System.EventHandler(this.Btcadastrar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.Location = new System.Drawing.Point(452, 476);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(185, 49);
            this.btcancelar.TabIndex = 7;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.Btcancelar_Click);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(301, 167);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(325, 41);
            this.txtnome.TabIndex = 8;
            // 
            // txtend
            // 
            this.txtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtend.Location = new System.Drawing.Point(301, 217);
            this.txtend.Margin = new System.Windows.Forms.Padding(4);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(325, 41);
            this.txtend.TabIndex = 9;
            // 
            // txtbairro
            // 
            this.txtbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbairro.Location = new System.Drawing.Point(301, 264);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(325, 41);
            this.txtbairro.TabIndex = 10;
            // 
            // txtcid
            // 
            this.txtcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid.Location = new System.Drawing.Point(301, 314);
            this.txtcid.Margin = new System.Windows.Forms.Padding(4);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(325, 41);
            this.txtcid.TabIndex = 11;
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(301, 365);
            this.txttel.Margin = new System.Windows.Forms.Padding(4);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(325, 41);
            this.txttel.TabIndex = 12;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btLimpar.Location = new System.Drawing.Point(242, 476);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(185, 49);
            this.btLimpar.TabIndex = 13;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.BtLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "CodAmigo:";
            // 
            // lblCodAmigo
            // 
            this.lblCodAmigo.AutoSize = true;
            this.lblCodAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodAmigo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCodAmigo.Location = new System.Drawing.Point(295, 125);
            this.lblCodAmigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodAmigo.Name = "lblCodAmigo";
            this.lblCodAmigo.Size = new System.Drawing.Size(33, 36);
            this.lblCodAmigo.TabIndex = 15;
            this.lblCodAmigo.Text = "1";
            this.lblCodAmigo.Click += new System.EventHandler(this.lblCodAmigo_Click);
            // 
            // Amigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 556);
            this.Controls.Add(this.lblCodAmigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lblcid);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Amigos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lblcid;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodAmigo;
    }
}