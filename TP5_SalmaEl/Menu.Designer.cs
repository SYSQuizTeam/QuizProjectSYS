namespace TP5_SalmaEl
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filièresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matièresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.affichageToolStripMenuItem,
            this.bilanToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filièresToolStripMenuItem,
            this.matièresToolStripMenuItem,
            this.etudiantsToolStripMenuItem,
            this.notesToolStripMenuItem,
            this.modulesToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            this.gestionToolStripMenuItem.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click);
            // 
            // filièresToolStripMenuItem
            // 
            this.filièresToolStripMenuItem.Name = "filièresToolStripMenuItem";
            this.filièresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filièresToolStripMenuItem.Text = "Filières";
            this.filièresToolStripMenuItem.Click += new System.EventHandler(this.filièresToolStripMenuItem_Click);
            // 
            // matièresToolStripMenuItem
            // 
            this.matièresToolStripMenuItem.Name = "matièresToolStripMenuItem";
            this.matièresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.matièresToolStripMenuItem.Text = "Matières";
            this.matièresToolStripMenuItem.Click += new System.EventHandler(this.matièresToolStripMenuItem_Click);
            // 
            // etudiantsToolStripMenuItem
            // 
            this.etudiantsToolStripMenuItem.Name = "etudiantsToolStripMenuItem";
            this.etudiantsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.etudiantsToolStripMenuItem.Text = "Etudiants";
            this.etudiantsToolStripMenuItem.Click += new System.EventHandler(this.etudiantsToolStripMenuItem_Click);
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notesToolStripMenuItem.Text = "Notes";
            this.notesToolStripMenuItem.Click += new System.EventHandler(this.notesToolStripMenuItem_Click);
            // 
            // modulesToolStripMenuItem
            // 
            this.modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            this.modulesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modulesToolStripMenuItem.Text = "Modules";
            this.modulesToolStripMenuItem.Click += new System.EventHandler(this.modulesToolStripMenuItem_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // bilanToolStripMenuItem
            // 
            this.bilanToolStripMenuItem.Name = "bilanToolStripMenuItem";
            this.bilanToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.bilanToolStripMenuItem.Text = "Bilan";
            this.bilanToolStripMenuItem.Click += new System.EventHandler(this.bilanToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filièresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matièresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulesToolStripMenuItem;
    }
}

