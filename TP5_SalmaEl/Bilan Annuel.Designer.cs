namespace TP5_SalmaEl
{
    partial class Bilan_Annuel
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
            this.dataGridBilanAnnuel = new System.Windows.Forms.DataGridView();
            this.MoyenneAnnText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RechercherBtn = new System.Windows.Forms.Button();
            this.NiveauCombo = new System.Windows.Forms.ComboBox();
            this.EtudiantCombo = new System.Windows.Forms.ComboBox();
            this.FiliereCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBilanAnnuel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBilanAnnuel
            // 
            this.dataGridBilanAnnuel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBilanAnnuel.Location = new System.Drawing.Point(59, 152);
            this.dataGridBilanAnnuel.Name = "dataGridBilanAnnuel";
            this.dataGridBilanAnnuel.Size = new System.Drawing.Size(686, 221);
            this.dataGridBilanAnnuel.TabIndex = 19;
            // 
            // MoyenneAnnText
            // 
            this.MoyenneAnnText.Location = new System.Drawing.Point(370, 404);
            this.MoyenneAnnText.Name = "MoyenneAnnText";
            this.MoyenneAnnText.Size = new System.Drawing.Size(197, 20);
            this.MoyenneAnnText.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Moyenne Annuel";
            // 
            // RechercherBtn
            // 
            this.RechercherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechercherBtn.Location = new System.Drawing.Point(434, 70);
            this.RechercherBtn.Name = "RechercherBtn";
            this.RechercherBtn.Size = new System.Drawing.Size(211, 31);
            this.RechercherBtn.TabIndex = 16;
            this.RechercherBtn.Text = "Rechercher";
            this.RechercherBtn.UseVisualStyleBackColor = true;
            this.RechercherBtn.Click += new System.EventHandler(this.RechercherBtn_Click);
            // 
            // NiveauCombo
            // 
            this.NiveauCombo.FormattingEnabled = true;
            this.NiveauCombo.Location = new System.Drawing.Point(434, 30);
            this.NiveauCombo.Name = "NiveauCombo";
            this.NiveauCombo.Size = new System.Drawing.Size(211, 21);
            this.NiveauCombo.TabIndex = 15;
            this.NiveauCombo.SelectedIndexChanged += new System.EventHandler(this.NiveauCombo_SelectedIndexChanged);
            // 
            // EtudiantCombo
            // 
            this.EtudiantCombo.FormattingEnabled = true;
            this.EtudiantCombo.Location = new System.Drawing.Point(153, 80);
            this.EtudiantCombo.Name = "EtudiantCombo";
            this.EtudiantCombo.Size = new System.Drawing.Size(181, 21);
            this.EtudiantCombo.TabIndex = 14;
            // 
            // FiliereCombo
            // 
            this.FiliereCombo.FormattingEnabled = true;
            this.FiliereCombo.Location = new System.Drawing.Point(153, 30);
            this.FiliereCombo.Name = "FiliereCombo";
            this.FiliereCombo.Size = new System.Drawing.Size(181, 21);
            this.FiliereCombo.TabIndex = 13;
            this.FiliereCombo.SelectedIndexChanged += new System.EventHandler(this.FiliereCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Niveau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Etudiant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filière";
            // 
            // Bilan_Annuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridBilanAnnuel);
            this.Controls.Add(this.MoyenneAnnText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RechercherBtn);
            this.Controls.Add(this.NiveauCombo);
            this.Controls.Add(this.EtudiantCombo);
            this.Controls.Add(this.FiliereCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bilan_Annuel";
            this.Text = "Bilan_Annuel";
            this.Load += new System.EventHandler(this.Bilan_Annuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBilanAnnuel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBilanAnnuel;
        private System.Windows.Forms.TextBox MoyenneAnnText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RechercherBtn;
        private System.Windows.Forms.ComboBox NiveauCombo;
        private System.Windows.Forms.ComboBox EtudiantCombo;
        private System.Windows.Forms.ComboBox FiliereCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}