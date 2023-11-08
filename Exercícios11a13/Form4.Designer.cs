
namespace Exercícios11a13
{
    partial class Frmarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmarea));
            this.txtlarg = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.txtareatotal = new System.Windows.Forms.TextBox();
            this.txtnomecom = new System.Windows.Forms.TextBox();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.lbllarg = new System.Windows.Forms.Label();
            this.lblnomecom = new System.Windows.Forms.Label();
            this.lblcomp = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.lblareatotal = new System.Windows.Forms.Label();
            this.btncalcarea = new System.Windows.Forms.Button();
            this.btnlimpararea = new System.Windows.Forms.Button();
            this.btnvoltaarea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtlarg
            // 
            this.txtlarg.Location = new System.Drawing.Point(350, 82);
            this.txtlarg.Name = "txtlarg";
            this.txtlarg.Size = new System.Drawing.Size(100, 20);
            this.txtlarg.TabIndex = 0;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(350, 215);
            this.txtarea.Multiline = true;
            this.txtarea.Name = "txtarea";
            this.txtarea.ReadOnly = true;
            this.txtarea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtarea.Size = new System.Drawing.Size(146, 46);
            this.txtarea.TabIndex = 1;
            // 
            // txtareatotal
            // 
            this.txtareatotal.Enabled = false;
            this.txtareatotal.Location = new System.Drawing.Point(350, 267);
            this.txtareatotal.Name = "txtareatotal";
            this.txtareatotal.Size = new System.Drawing.Size(188, 20);
            this.txtareatotal.TabIndex = 2;
            this.txtareatotal.Visible = false;
            // 
            // txtnomecom
            // 
            this.txtnomecom.Location = new System.Drawing.Point(350, 168);
            this.txtnomecom.Name = "txtnomecom";
            this.txtnomecom.Size = new System.Drawing.Size(100, 20);
            this.txtnomecom.TabIndex = 3;
            // 
            // txtcomp
            // 
            this.txtcomp.Location = new System.Drawing.Point(350, 124);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(100, 20);
            this.txtcomp.TabIndex = 4;
            // 
            // lbllarg
            // 
            this.lbllarg.AutoSize = true;
            this.lbllarg.Location = new System.Drawing.Point(193, 85);
            this.lbllarg.Name = "lbllarg";
            this.lbllarg.Size = new System.Drawing.Size(140, 13);
            this.lbllarg.TabIndex = 5;
            this.lbllarg.Text = "Digite a largura do cômodo: ";
            // 
            // lblnomecom
            // 
            this.lblnomecom.AutoSize = true;
            this.lblnomecom.Location = new System.Drawing.Point(202, 168);
            this.lblnomecom.Name = "lblnomecom";
            this.lblnomecom.Size = new System.Drawing.Size(131, 13);
            this.lblnomecom.TabIndex = 6;
            this.lblnomecom.Text = "Digite o nome do cômodo:";
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.Location = new System.Drawing.Point(168, 124);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(165, 13);
            this.lblcomp.TabIndex = 7;
            this.lblcomp.Text = "Digite o comprimento do cômodo:";
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(245, 215);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(88, 13);
            this.lblarea.TabIndex = 8;
            this.lblarea.Text = "Área do cômodo:";
            // 
            // lblareatotal
            // 
            this.lblareatotal.AutoSize = true;
            this.lblareatotal.Location = new System.Drawing.Point(257, 270);
            this.lblareatotal.Name = "lblareatotal";
            this.lblareatotal.Size = new System.Drawing.Size(83, 13);
            this.lblareatotal.TabIndex = 9;
            this.lblareatotal.Text = "Área do imóvel: ";
            this.lblareatotal.Visible = false;
            // 
            // btncalcarea
            // 
            this.btncalcarea.Location = new System.Drawing.Point(229, 358);
            this.btncalcarea.Name = "btncalcarea";
            this.btncalcarea.Size = new System.Drawing.Size(132, 41);
            this.btncalcarea.TabIndex = 10;
            this.btncalcarea.Text = "Calcular";
            this.btncalcarea.UseVisualStyleBackColor = true;
            this.btncalcarea.Click += new System.EventHandler(this.btncalcarea_Click);
            // 
            // btnlimpararea
            // 
            this.btnlimpararea.Location = new System.Drawing.Point(432, 358);
            this.btnlimpararea.Name = "btnlimpararea";
            this.btnlimpararea.Size = new System.Drawing.Size(132, 41);
            this.btnlimpararea.TabIndex = 11;
            this.btnlimpararea.Text = "Limpar";
            this.btnlimpararea.UseVisualStyleBackColor = true;
            this.btnlimpararea.Click += new System.EventHandler(this.btnlimpararea_Click);
            // 
            // btnvoltaarea
            // 
            this.btnvoltaarea.Location = new System.Drawing.Point(606, 358);
            this.btnvoltaarea.Name = "btnvoltaarea";
            this.btnvoltaarea.Size = new System.Drawing.Size(120, 41);
            this.btnvoltaarea.TabIndex = 12;
            this.btnvoltaarea.Text = "Voltar";
            this.btnvoltaarea.UseVisualStyleBackColor = true;
            this.btnvoltaarea.Click += new System.EventHandler(this.btnvoltaarea_Click);
            // 
            // Frmarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltaarea);
            this.Controls.Add(this.btnlimpararea);
            this.Controls.Add(this.btncalcarea);
            this.Controls.Add(this.lblareatotal);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.lblcomp);
            this.Controls.Add(this.lblnomecom);
            this.Controls.Add(this.lbllarg);
            this.Controls.Add(this.txtcomp);
            this.Controls.Add(this.txtnomecom);
            this.Controls.Add(this.txtareatotal);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtlarg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área da Casa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlarg;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.TextBox txtareatotal;
        private System.Windows.Forms.TextBox txtnomecom;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.Label lbllarg;
        private System.Windows.Forms.Label lblnomecom;
        private System.Windows.Forms.Label lblcomp;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Label lblareatotal;
        private System.Windows.Forms.Button btncalcarea;
        private System.Windows.Forms.Button btnlimpararea;
        private System.Windows.Forms.Button btnvoltaarea;
    }
}