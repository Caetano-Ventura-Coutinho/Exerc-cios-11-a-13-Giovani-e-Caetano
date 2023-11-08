
namespace Exercícios11a13
{
    partial class Frmtabuada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmtabuada));
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncalcwhile11 = new System.Windows.Forms.Button();
            this.btncalcdo11 = new System.Windows.Forms.Button();
            this.btncalcfor11 = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(82, 114);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(92, 13);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Digite um número:";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(82, 168);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(53, 13);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Tabuada:";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(193, 111);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 2;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(193, 165);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresult.Size = new System.Drawing.Size(328, 60);
            this.txtresult.TabIndex = 3;
            // 
            // btncalcwhile11
            // 
            this.btncalcwhile11.Location = new System.Drawing.Point(85, 248);
            this.btncalcwhile11.Name = "btncalcwhile11";
            this.btncalcwhile11.Size = new System.Drawing.Size(89, 23);
            this.btncalcwhile11.TabIndex = 4;
            this.btncalcwhile11.Text = "Calcular ( while)";
            this.btncalcwhile11.UseVisualStyleBackColor = true;
            this.btncalcwhile11.Click += new System.EventHandler(this.btncalcular1_Click);
            // 
            // btncalcdo11
            // 
            this.btncalcdo11.Location = new System.Drawing.Point(193, 248);
            this.btncalcdo11.Name = "btncalcdo11";
            this.btncalcdo11.Size = new System.Drawing.Size(82, 23);
            this.btncalcdo11.TabIndex = 5;
            this.btncalcdo11.Text = "Calcular ( do)";
            this.btncalcdo11.UseVisualStyleBackColor = true;
            this.btncalcdo11.Click += new System.EventHandler(this.btncalcdo11_Click);
            // 
            // btncalcfor11
            // 
            this.btncalcfor11.Location = new System.Drawing.Point(297, 248);
            this.btncalcfor11.Name = "btncalcfor11";
            this.btncalcfor11.Size = new System.Drawing.Size(92, 23);
            this.btncalcfor11.TabIndex = 6;
            this.btncalcfor11.Text = "Calcular ( for)";
            this.btncalcfor11.UseVisualStyleBackColor = true;
            this.btncalcfor11.Click += new System.EventHandler(this.btncalcfor11_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(85, 301);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(193, 301);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Frmtabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcfor11);
            this.Controls.Add(this.btncalcdo11);
            this.Controls.Add(this.btncalcwhile11);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmtabuada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada";
            this.Load += new System.EventHandler(this.Frmtabuada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncalcwhile11;
        private System.Windows.Forms.Button btncalcdo11;
        private System.Windows.Forms.Button btncalcfor11;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}