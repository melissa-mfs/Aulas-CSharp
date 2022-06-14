namespace ApagarCliente
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
            this.grupo1 = new System.Windows.Forms.GroupBox();
            this.txtcodcli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.grupo2 = new System.Windows.Forms.GroupBox();
            this.txtcnh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdatanasc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnnao = new System.Windows.Forms.Button();
            this.txtcli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsim = new System.Windows.Forms.Button();
            this.grupo1.SuspendLayout();
            this.grupo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo1
            // 
            this.grupo1.Controls.Add(this.txtcodcli);
            this.grupo1.Controls.Add(this.label1);
            this.grupo1.Controls.Add(this.btnexcluir);
            this.grupo1.Location = new System.Drawing.Point(12, 12);
            this.grupo1.Name = "grupo1";
            this.grupo1.Size = new System.Drawing.Size(776, 65);
            this.grupo1.TabIndex = 0;
            this.grupo1.TabStop = false;
            // 
            // txtcodcli
            // 
            this.txtcodcli.Location = new System.Drawing.Point(240, 33);
            this.txtcodcli.Name = "txtcodcli";
            this.txtcodcli.Size = new System.Drawing.Size(331, 20);
            this.txtcodcli.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cód. Cliente";
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(602, 30);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 0;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.Btnexcluir_Click);
            // 
            // grupo2
            // 
            this.grupo2.Controls.Add(this.txtcnh);
            this.grupo2.Controls.Add(this.label6);
            this.grupo2.Controls.Add(this.txtdatanasc);
            this.grupo2.Controls.Add(this.label7);
            this.grupo2.Controls.Add(this.txtpais);
            this.grupo2.Controls.Add(this.label8);
            this.grupo2.Controls.Add(this.txtestado);
            this.grupo2.Controls.Add(this.label9);
            this.grupo2.Controls.Add(this.txtcidade);
            this.grupo2.Controls.Add(this.label4);
            this.grupo2.Controls.Add(this.txtbairro);
            this.grupo2.Controls.Add(this.label5);
            this.grupo2.Controls.Add(this.txtendereco);
            this.grupo2.Controls.Add(this.label3);
            this.grupo2.Controls.Add(this.btnnao);
            this.grupo2.Controls.Add(this.txtcli);
            this.grupo2.Controls.Add(this.label2);
            this.grupo2.Controls.Add(this.btnsim);
            this.grupo2.Location = new System.Drawing.Point(12, 83);
            this.grupo2.Name = "grupo2";
            this.grupo2.Size = new System.Drawing.Size(776, 355);
            this.grupo2.TabIndex = 1;
            this.grupo2.TabStop = false;
            this.grupo2.Text = "Deseja excluir?";
            // 
            // txtcnh
            // 
            this.txtcnh.Location = new System.Drawing.Point(154, 277);
            this.txtcnh.Name = "txtcnh";
            this.txtcnh.Size = new System.Drawing.Size(331, 20);
            this.txtcnh.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "CNH";
            // 
            // txtdatanasc
            // 
            this.txtdatanasc.Location = new System.Drawing.Point(154, 241);
            this.txtdatanasc.Name = "txtdatanasc";
            this.txtdatanasc.Size = new System.Drawing.Size(331, 20);
            this.txtdatanasc.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data Nasc.";
            // 
            // txtpais
            // 
            this.txtpais.Location = new System.Drawing.Point(154, 205);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(331, 20);
            this.txtpais.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Pais";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(154, 169);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(331, 20);
            this.txtestado.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Estado";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(154, 127);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(331, 20);
            this.txtcidade.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cidade";
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(154, 91);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(331, 20);
            this.txtbairro.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bairro";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(154, 55);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(331, 20);
            this.txtendereco.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endereço";
            // 
            // btnnao
            // 
            this.btnnao.Location = new System.Drawing.Point(626, 157);
            this.btnnao.Name = "btnnao";
            this.btnnao.Size = new System.Drawing.Size(75, 23);
            this.btnnao.TabIndex = 6;
            this.btnnao.Text = "Não";
            this.btnnao.UseVisualStyleBackColor = true;
            this.btnnao.Click += new System.EventHandler(this.Btnnao_Click);
            // 
            // txtcli
            // 
            this.txtcli.Location = new System.Drawing.Point(154, 19);
            this.txtcli.Name = "txtcli";
            this.txtcli.Size = new System.Drawing.Size(331, 20);
            this.txtcli.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // btnsim
            // 
            this.btnsim.Location = new System.Drawing.Point(626, 121);
            this.btnsim.Name = "btnsim";
            this.btnsim.Size = new System.Drawing.Size(75, 23);
            this.btnsim.TabIndex = 3;
            this.btnsim.Text = "Sim";
            this.btnsim.UseVisualStyleBackColor = true;
            this.btnsim.Click += new System.EventHandler(this.Btnsim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupo2);
            this.Controls.Add(this.grupo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupo1.ResumeLayout(false);
            this.grupo1.PerformLayout();
            this.grupo2.ResumeLayout(false);
            this.grupo2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo1;
        private System.Windows.Forms.TextBox txtcodcli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.GroupBox grupo2;
        private System.Windows.Forms.TextBox txtcnh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdatanasc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnnao;
        private System.Windows.Forms.TextBox txtcli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsim;
    }
}

