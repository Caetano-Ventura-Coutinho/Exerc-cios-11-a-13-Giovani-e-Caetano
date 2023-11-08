
namespace Exercícios11a13
{
    partial class Frmprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmprincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progamasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.áreaDaCasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.progamasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // progamasToolStripMenuItem
            // 
            this.progamasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabuadaToolStripMenuItem,
            this.temperaturaToolStripMenuItem,
            this.áreaDaCasaToolStripMenuItem});
            this.progamasToolStripMenuItem.Name = "progamasToolStripMenuItem";
            this.progamasToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.progamasToolStripMenuItem.Text = "Progamas";
            this.progamasToolStripMenuItem.Click += new System.EventHandler(this.progamasToolStripMenuItem_Click);
            // 
            // tabuadaToolStripMenuItem
            // 
            this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.tabuadaToolStripMenuItem.Text = "Tabuada";
            this.tabuadaToolStripMenuItem.Click += new System.EventHandler(this.tabuadaToolStripMenuItem_Click);
            // 
            // temperaturaToolStripMenuItem
            // 
            this.temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            this.temperaturaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.temperaturaToolStripMenuItem.Text = "Temperatura";
            this.temperaturaToolStripMenuItem.Click += new System.EventHandler(this.temperaturaToolStripMenuItem_Click);
            // 
            // áreaDaCasaToolStripMenuItem
            // 
            this.áreaDaCasaToolStripMenuItem.Name = "áreaDaCasaToolStripMenuItem";
            this.áreaDaCasaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.áreaDaCasaToolStripMenuItem.Text = "Área da Casa";
            this.áreaDaCasaToolStripMenuItem.Click += new System.EventHandler(this.áreaDaCasaToolStripMenuItem_Click);
            // 
            // Frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem progamasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áreaDaCasaToolStripMenuItem;
    }
}

