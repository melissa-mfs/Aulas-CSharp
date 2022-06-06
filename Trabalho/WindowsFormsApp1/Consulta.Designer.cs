namespace WindowsFormsApp1
{
    partial class Consulta
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
            this.grupo3 = new System.Windows.Forms.GroupBox();
            this.dgConsulta = new System.Windows.Forms.DataGridView();
            this.grupo1 = new System.Windows.Forms.GroupBox();
            this.btConsultaLivro = new System.Windows.Forms.Button();
            this.txtcodnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btConsultaData = new System.Windows.Forms.Button();
            this.txtdataempdev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grupo3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).BeginInit();
            this.grupo1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo3
            // 
            this.grupo3.Controls.Add(this.dgConsulta);
            this.grupo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo3.Location = new System.Drawing.Point(40, 239);
            this.grupo3.Margin = new System.Windows.Forms.Padding(4);
            this.grupo3.Name = "grupo3";
            this.grupo3.Padding = new System.Windows.Forms.Padding(4);
            this.grupo3.Size = new System.Drawing.Size(1050, 463);
            this.grupo3.TabIndex = 3;
            this.grupo3.TabStop = false;
            // 
            // dgConsulta
            // 
            this.dgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsulta.Location = new System.Drawing.Point(26, 43);
            this.dgConsulta.Name = "dgConsulta";
            this.dgConsulta.RowHeadersWidth = 51;
            this.dgConsulta.RowTemplate.Height = 24;
            this.dgConsulta.Size = new System.Drawing.Size(988, 408);
            this.dgConsulta.TabIndex = 0;
            // 
            // grupo1
            // 
            this.grupo1.Controls.Add(this.label3);
            this.grupo1.Controls.Add(this.btConsultaLivro);
            this.grupo1.Controls.Add(this.txtcodnome);
            this.grupo1.Controls.Add(this.label1);
            this.grupo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo1.Location = new System.Drawing.Point(40, 24);
            this.grupo1.Margin = new System.Windows.Forms.Padding(4);
            this.grupo1.Name = "grupo1";
            this.grupo1.Padding = new System.Windows.Forms.Padding(4);
            this.grupo1.Size = new System.Drawing.Size(1050, 96);
            this.grupo1.TabIndex = 2;
            this.grupo1.TabStop = false;
            // 
            // btConsultaLivro
            // 
            this.btConsultaLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultaLivro.Location = new System.Drawing.Point(829, 20);
            this.btConsultaLivro.Margin = new System.Windows.Forms.Padding(4);
            this.btConsultaLivro.Name = "btConsultaLivro";
            this.btConsultaLivro.Size = new System.Drawing.Size(185, 49);
            this.btConsultaLivro.TabIndex = 2;
            this.btConsultaLivro.Text = "Consultar";
            this.btConsultaLivro.UseVisualStyleBackColor = true;
            this.btConsultaLivro.Click += new System.EventHandler(this.btConsultaLivro_Click);
            // 
            // txtcodnome
            // 
            this.txtcodnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodnome.Location = new System.Drawing.Point(353, 29);
            this.txtcodnome.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodnome.Name = "txtcodnome";
            this.txtcodnome.Size = new System.Drawing.Size(372, 34);
            this.txtcodnome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empréstimo por livro:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btConsultaData);
            this.groupBox2.Controls.Add(this.txtdataempdev);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 128);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1050, 103);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btConsultaData
            // 
            this.btConsultaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultaData.Location = new System.Drawing.Point(829, 19);
            this.btConsultaData.Margin = new System.Windows.Forms.Padding(4);
            this.btConsultaData.Name = "btConsultaData";
            this.btConsultaData.Size = new System.Drawing.Size(185, 49);
            this.btConsultaData.TabIndex = 3;
            this.btConsultaData.Text = "Consultar";
            this.btConsultaData.UseVisualStyleBackColor = true;
            this.btConsultaData.Click += new System.EventHandler(this.btConsultaData_Click);
            // 
            // txtdataempdev
            // 
            this.txtdataempdev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdataempdev.Location = new System.Drawing.Point(353, 34);
            this.txtdataempdev.Margin = new System.Windows.Forms.Padding(4);
            this.txtdataempdev.Name = "txtdataempdev";
            this.txtdataempdev.Size = new System.Drawing.Size(372, 34);
            this.txtdataempdev.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Empréstimo por data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(349, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data: dd/mm/yyyy ou dd/mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(349, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Informe: Código ou nome do Livro";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 721);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grupo3);
            this.Controls.Add(this.grupo1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grupo3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).EndInit();
            this.grupo1.ResumeLayout(false);
            this.grupo1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo3;
        private System.Windows.Forms.GroupBox grupo1;
        private System.Windows.Forms.TextBox txtcodnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdataempdev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgConsulta;
        private System.Windows.Forms.Button btConsultaLivro;
        private System.Windows.Forms.Button btConsultaData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}