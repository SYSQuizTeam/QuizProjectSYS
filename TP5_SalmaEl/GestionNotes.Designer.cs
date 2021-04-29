namespace TP5_SalmaEl
{
    partial class GestionNotes
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
            this.Rechercher = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Nouveau = new System.Windows.Forms.Button();
            this.MatiereCombo = new System.Windows.Forms.ComboBox();
            this.NoteTexte = new System.Windows.Forms.TextBox();
            this.CodeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rechercher
            // 
            this.Rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rechercher.Location = new System.Drawing.Point(569, 129);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(141, 33);
            this.Rechercher.TabIndex = 21;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.Location = new System.Drawing.Point(569, 65);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(141, 35);
            this.Supprimer.TabIndex = 20;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(384, 161);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(141, 32);
            this.Modifier.TabIndex = 19;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Location = new System.Drawing.Point(384, 113);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(141, 33);
            this.Ajouter.TabIndex = 18;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Nouveau
            // 
            this.Nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nouveau.Location = new System.Drawing.Point(384, 63);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(141, 35);
            this.Nouveau.TabIndex = 17;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = true;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // MatiereCombo
            // 
            this.MatiereCombo.FormattingEnabled = true;
            this.MatiereCombo.Location = new System.Drawing.Point(145, 120);
            this.MatiereCombo.Name = "MatiereCombo";
            this.MatiereCombo.Size = new System.Drawing.Size(154, 21);
            this.MatiereCombo.TabIndex = 16;
          //  this.MatiereCombo.TextChanged += new System.EventHandler(this.CodeText_TextChanged);
            // 
            // NoteTexte
            // 
            this.NoteTexte.Location = new System.Drawing.Point(145, 173);
            this.NoteTexte.Name = "NoteTexte";
            this.NoteTexte.Size = new System.Drawing.Size(154, 20);
            this.NoteTexte.TabIndex = 15;
            // 
            // CodeText
            // 
            this.CodeText.Location = new System.Drawing.Point(145, 65);
            this.CodeText.Name = "CodeText";
            this.CodeText.Size = new System.Drawing.Size(154, 20);
            this.CodeText.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Matière";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Code Eleve";
            // 
            // GestionNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 237);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.MatiereCombo);
            this.Controls.Add(this.NoteTexte);
            this.Controls.Add(this.CodeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionNotes";
            this.Text = "GestionNotes";
            this.Load += new System.EventHandler(this.GestionNotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.ComboBox MatiereCombo;
        private System.Windows.Forms.TextBox NoteTexte;
        private System.Windows.Forms.TextBox CodeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}