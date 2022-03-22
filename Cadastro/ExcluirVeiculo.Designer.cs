namespace Cadastro
{
    partial class ExcluirVeiculo
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
            this.grupo1 = new System.Windows.Forms.GroupBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.txtcodvei = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grupo2 = new System.Windows.Forms.GroupBox();
            this.btnnao = new System.Windows.Forms.Button();
            this.btnsim = new System.Windows.Forms.Button();
            this.txtano = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grupo1.SuspendLayout();
            this.grupo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo1
            // 
            this.grupo1.Controls.Add(this.btnexcluir);
            this.grupo1.Controls.Add(this.txtcodvei);
            this.grupo1.Controls.Add(this.label6);
            this.grupo1.Location = new System.Drawing.Point(12, 12);
            this.grupo1.Name = "grupo1";
            this.grupo1.Size = new System.Drawing.Size(459, 64);
            this.grupo1.TabIndex = 0;
            this.grupo1.TabStop = false;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(329, 25);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnexcluir.Size = new System.Drawing.Size(72, 20);
            this.btnexcluir.TabIndex = 29;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.Btnexcluir_Click);
            // 
            // txtcodvei
            // 
            this.txtcodvei.Location = new System.Drawing.Point(108, 25);
            this.txtcodvei.Name = "txtcodvei";
            this.txtcodvei.Size = new System.Drawing.Size(186, 20);
            this.txtcodvei.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Cod. Veículo";
            // 
            // grupo2
            // 
            this.grupo2.Controls.Add(this.btnnao);
            this.grupo2.Controls.Add(this.btnsim);
            this.grupo2.Controls.Add(this.txtano);
            this.grupo2.Controls.Add(this.txtmodelo);
            this.grupo2.Controls.Add(this.txtcor);
            this.grupo2.Controls.Add(this.txtplaca);
            this.grupo2.Controls.Add(this.txtmarca);
            this.grupo2.Controls.Add(this.label5);
            this.grupo2.Controls.Add(this.label4);
            this.grupo2.Controls.Add(this.label3);
            this.grupo2.Controls.Add(this.label2);
            this.grupo2.Controls.Add(this.label1);
            this.grupo2.Location = new System.Drawing.Point(12, 82);
            this.grupo2.Name = "grupo2";
            this.grupo2.Size = new System.Drawing.Size(459, 356);
            this.grupo2.TabIndex = 1;
            this.grupo2.TabStop = false;
            this.grupo2.Text = "Deseja excluir?";
            // 
            // btnnao
            // 
            this.btnnao.Location = new System.Drawing.Point(263, 314);
            this.btnnao.Name = "btnnao";
            this.btnnao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnnao.Size = new System.Drawing.Size(72, 20);
            this.btnnao.TabIndex = 31;
            this.btnnao.Text = "Não";
            this.btnnao.UseVisualStyleBackColor = true;
            this.btnnao.Click += new System.EventHandler(this.Btnnao_Click);
            // 
            // btnsim
            // 
            this.btnsim.Location = new System.Drawing.Point(118, 314);
            this.btnsim.Name = "btnsim";
            this.btnsim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsim.Size = new System.Drawing.Size(72, 20);
            this.btnsim.TabIndex = 30;
            this.btnsim.Text = "Sim";
            this.btnsim.UseVisualStyleBackColor = true;
            this.btnsim.Click += new System.EventHandler(this.Btnsim_Click);
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(179, 255);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(186, 20);
            this.txtano.TabIndex = 26;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(179, 84);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(186, 20);
            this.txtmodelo.TabIndex = 24;
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(179, 136);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(186, 20);
            this.txtcor.TabIndex = 23;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(179, 200);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(186, 20);
            this.txtplaca.TabIndex = 22;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(179, 27);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(186, 20);
            this.txtmarca.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Marca:";
            // 
            // ExcluirVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.grupo2);
            this.Controls.Add(this.grupo1);
            this.Name = "ExcluirVeiculo";
            this.Text = "ExcluirVeiculo";
            this.Load += new System.EventHandler(this.ExcluirVeiculo_Load);
            this.grupo1.ResumeLayout(false);
            this.grupo1.PerformLayout();
            this.grupo2.ResumeLayout(false);
            this.grupo2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo1;
        private System.Windows.Forms.GroupBox grupo2;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodvei;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnnao;
        private System.Windows.Forms.Button btnsim;
    }
}