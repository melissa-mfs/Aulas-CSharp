namespace locadpranoite
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
            this.RR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlpesquisa = new System.Windows.Forms.Panel();
            this.btnpesquisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RR
            // 
            this.RR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RR.Location = new System.Drawing.Point(185, 55);
            this.RR.Name = "RR";
            this.RR.Size = new System.Drawing.Size(174, 26);
            this.RR.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuário:";
            // 
            // pnlpesquisa
            // 
            this.pnlpesquisa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlpesquisa.Location = new System.Drawing.Point(47, 113);
            this.pnlpesquisa.Name = "pnlpesquisa";
            this.pnlpesquisa.Size = new System.Drawing.Size(490, 259);
            this.pnlpesquisa.TabIndex = 9;
            // 
            // btnpesquisa
            // 
            this.btnpesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisa.Location = new System.Drawing.Point(405, 58);
            this.btnpesquisa.Name = "btnpesquisa";
            this.btnpesquisa.Size = new System.Drawing.Size(97, 26);
            this.btnpesquisa.TabIndex = 10;
            this.btnpesquisa.Text = "Pesquisar";
            this.btnpesquisa.UseVisualStyleBackColor = true;
            this.btnpesquisa.Click += new System.EventHandler(this.Btnpesquisa_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 409);
            this.Controls.Add(this.btnpesquisa);
            this.Controls.Add(this.pnlpesquisa);
            this.Controls.Add(this.RR);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlpesquisa;
        private System.Windows.Forms.Button btnpesquisa;
    }
}