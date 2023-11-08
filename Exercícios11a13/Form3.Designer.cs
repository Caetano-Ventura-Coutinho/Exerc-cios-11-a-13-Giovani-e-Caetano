
namespace Exercícios11a13
{
    partial class Frmtemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmtemp));
            this.lblnum1 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncalcwhile12 = new System.Windows.Forms.Button();
            this.btncalcdo12 = new System.Windows.Forms.Button();
            this.btncalcfor11 = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(45, 128);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(157, 13);
            this.lblnum1.TabIndex = 1;
            this.lblnum1.Text = "Digite a temperatura em celsius:";
            this.lblnum1.Click += new System.EventHandler(this.lblnum1_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(225, 125);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 3;
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(45, 170);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(140, 13);
            this.lblnum2.TabIndex = 4;
            this.lblnum2.Text = "Temperatura em Fahrenheit:";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(225, 167);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresult.Size = new System.Drawing.Size(202, 48);
            this.txtresult.TabIndex = 5;
            this.txtresult.TextChanged += new System.EventHandler(this.txtresult_TextChanged);
            // 
            // btncalcwhile12
            // 
            this.btncalcwhile12.Location = new System.Drawing.Point(48, 245);
            this.btncalcwhile12.Name = "btncalcwhile12";
            this.btncalcwhile12.Size = new System.Drawing.Size(89, 23);
            this.btncalcwhile12.TabIndex = 6;
            this.btncalcwhile12.Text = "Calcular ( while)";
            this.btncalcwhile12.UseVisualStyleBackColor = true;
            this.btncalcwhile12.Click += new System.EventHandler(this.btncalcwhile11_Click);
            // 
            // btncalcdo12
            // 
            this.btncalcdo12.Location = new System.Drawing.Point(164, 245);
            this.btncalcdo12.Name = "btncalcdo12";
            this.btncalcdo12.Size = new System.Drawing.Size(82, 23);
            this.btncalcdo12.TabIndex = 7;
            this.btncalcdo12.Text = "Calcular ( do)";
            this.btncalcdo12.UseVisualStyleBackColor = true;
            this.btncalcdo12.Click += new System.EventHandler(this.btncalcdo11_Click);
            // 
            // btncalcfor11
            // 
            this.btncalcfor11.Location = new System.Drawing.Point(276, 245);
            this.btncalcfor11.Name = "btncalcfor11";
            this.btncalcfor11.Size = new System.Drawing.Size(92, 23);
            this.btncalcfor11.TabIndex = 8;
            this.btncalcfor11.Text = "Calcular ( for)";
            this.btncalcfor11.UseVisualStyleBackColor = true;
            this.btncalcfor11.Click += new System.EventHandler(this.btncalcfor11_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(48, 306);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 9;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(164, 306);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 10;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Frmtemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcfor11);
            this.Controls.Add(this.btncalcdo12);
            this.Controls.Add(this.btncalcwhile12);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblnum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmtemp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperatura";
            this.Load += new System.EventHandler(this.Frmtemp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncalcwhile12;
        private System.Windows.Forms.Button btncalcdo12;
        private System.Windows.Forms.Button btncalcfor11;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}