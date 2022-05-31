namespace WindowsFormsApp1
{
    partial class Emprestimos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdtdev = new System.Windows.Forms.TextBox();
            this.txtdtemp = new System.Windows.Forms.TextBox();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcodl = new System.Windows.Forms.TextBox();
            this.txtcoda = new System.Windows.Forms.TextBox();
            this.btlimpar = new System.Windows.Forms.Button();
            this.calendEmp = new System.Windows.Forms.MonthCalendar();
            this.btConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empréstimos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data Da Devolução:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data Do Emprestimo:";
            // 
            // txtdtdev
            // 
            this.txtdtdev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdtdev.Location = new System.Drawing.Point(327, 268);
            this.txtdtdev.Margin = new System.Windows.Forms.Padding(4);
            this.txtdtdev.Name = "txtdtdev";
            this.txtdtdev.Size = new System.Drawing.Size(277, 34);
            this.txtdtdev.TabIndex = 9;
            // 
            // txtdtemp
            // 
            this.txtdtemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdtemp.Location = new System.Drawing.Point(327, 226);
            this.txtdtemp.Margin = new System.Windows.Forms.Padding(4);
            this.txtdtemp.Name = "txtdtemp";
            this.txtdtemp.Size = new System.Drawing.Size(277, 34);
            this.txtdtemp.TabIndex = 8;
            // 
            // btcadastrar
            // 
            this.btcadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.Location = new System.Drawing.Point(43, 354);
            this.btcadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(185, 49);
            this.btcadastrar.TabIndex = 12;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.Click += new System.EventHandler(this.Btcadastrar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.Location = new System.Drawing.Point(709, 354);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(185, 49);
            this.btcancelar.TabIndex = 13;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.Btcancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cod. Livro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cod. Amigo:";
            // 
            // txtcodl
            // 
            this.txtcodl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodl.Location = new System.Drawing.Point(327, 126);
            this.txtcodl.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodl.Name = "txtcodl";
            this.txtcodl.Size = new System.Drawing.Size(277, 34);
            this.txtcodl.TabIndex = 18;
            // 
            // txtcoda
            // 
            this.txtcoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcoda.Location = new System.Drawing.Point(327, 179);
            this.txtcoda.Margin = new System.Windows.Forms.Padding(4);
            this.txtcoda.Name = "txtcoda";
            this.txtcoda.Size = new System.Drawing.Size(277, 34);
            this.txtcoda.TabIndex = 19;
            // 
            // btlimpar
            // 
            this.btlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btlimpar.Location = new System.Drawing.Point(257, 354);
            this.btlimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(185, 49);
            this.btlimpar.TabIndex = 20;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.Btlimpar_Click);
            // 
            // calendEmp
            // 
            this.calendEmp.Location = new System.Drawing.Point(644, 95);
            this.calendEmp.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calendEmp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.calendEmp.MinDate = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.calendEmp.Name = "calendEmp";
            this.calendEmp.TabIndex = 21;
            this.calendEmp.TodayDate = new System.DateTime(2022, 5, 31, 0, 0, 0, 0);
            this.calendEmp.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendEmp_DateChanged);
            // 
            // btConsulta
            // 
            this.btConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsulta.Location = new System.Drawing.Point(489, 354);
            this.btConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(185, 49);
            this.btConsulta.TabIndex = 22;
            this.btConsulta.Text = "Consultar";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // Emprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 428);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.calendEmp);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.txtcoda);
            this.Controls.Add(this.txtcodl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdtdev);
            this.Controls.Add(this.txtdtemp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Emprestimos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdtdev;
        private System.Windows.Forms.TextBox txtdtemp;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcodl;
        private System.Windows.Forms.TextBox txtcoda;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.MonthCalendar calendEmp;
        private System.Windows.Forms.Button btConsulta;
    }
}