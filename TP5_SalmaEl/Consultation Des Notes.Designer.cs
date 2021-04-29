namespace TP5_SalmaEl
{
    partial class Consultation_Des_Notes
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
            this.FiliereCombo = new System.Windows.Forms.ComboBox();
            this.MatiereCombo = new System.Windows.Forms.ComboBox();
            this.NiveauCombo = new System.Windows.Forms.ComboBox();
            this.RechercherBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MoyenneClasseText = new System.Windows.Forms.TextBox();
            this.dataGridConsultNotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filière";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matière";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Niveau";
            // 
            // FiliereCombo
            // 
            this.FiliereCombo.FormattingEnabled = true;
            this.FiliereCombo.Location = new System.Drawing.Point(141, 60);
            this.FiliereCombo.Name = "FiliereCombo";
            this.FiliereCombo.Size = new System.Drawing.Size(181, 21);
            this.FiliereCombo.TabIndex = 3;
            this.FiliereCombo.SelectedIndexChanged += new System.EventHandler(this.FiliereCombo_SelectedIndexChanged_1);
            // 
            // MatiereCombo
            // 
            this.MatiereCombo.FormattingEnabled = true;
            this.MatiereCombo.Location = new System.Drawing.Point(141, 110);
            this.MatiereCombo.Name = "MatiereCombo";
            this.MatiereCombo.Size = new System.Drawing.Size(181, 21);
            this.MatiereCombo.TabIndex = 4;
            // 
            // NiveauCombo
            // 
            this.NiveauCombo.FormattingEnabled = true;
            this.NiveauCombo.Location = new System.Drawing.Point(422, 60);
            this.NiveauCombo.Name = "NiveauCombo";
            this.NiveauCombo.Size = new System.Drawing.Size(211, 21);
            this.NiveauCombo.TabIndex = 5;
            this.NiveauCombo.SelectedIndexChanged += new System.EventHandler(this.NiveauCombo_SelectedIndexChanged_1);
            // 
            // RechercherBtn
            // 
            this.RechercherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechercherBtn.Location = new System.Drawing.Point(422, 100);
            this.RechercherBtn.Name = "RechercherBtn";
            this.RechercherBtn.Size = new System.Drawing.Size(211, 31);
            this.RechercherBtn.TabIndex = 6;
            this.RechercherBtn.Text = "Rechercher";
            this.RechercherBtn.UseVisualStyleBackColor = true;
            this.RechercherBtn.Click += new System.EventHandler(this.RechercherBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Moyenne de la classe";
            // 
            // MoyenneClasseText
            // 
            this.MoyenneClasseText.Location = new System.Drawing.Point(358, 434);
            this.MoyenneClasseText.Name = "MoyenneClasseText";
            this.MoyenneClasseText.Size = new System.Drawing.Size(197, 20);
            this.MoyenneClasseText.TabIndex = 8;
            // 
            // dataGridConsultNotes
            // 
            this.dataGridConsultNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultNotes.Location = new System.Drawing.Point(47, 182);
            this.dataGridConsultNotes.Name = "dataGridConsultNotes";
            this.dataGridConsultNotes.Size = new System.Drawing.Size(686, 221);
            this.dataGridConsultNotes.TabIndex = 9;
            // 
            // Consultation_Des_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.dataGridConsultNotes);
            this.Controls.Add(this.MoyenneClasseText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RechercherBtn);
            this.Controls.Add(this.NiveauCombo);
            this.Controls.Add(this.MatiereCombo);
            this.Controls.Add(this.FiliereCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Consultation_Des_Notes";
            this.Text = "Consultation_Des_Notes";
            this.Load += new System.EventHandler(this.Consultation_Des_Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FiliereCombo;
        private System.Windows.Forms.ComboBox MatiereCombo;
        private System.Windows.Forms.ComboBox NiveauCombo;
        private System.Windows.Forms.Button RechercherBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MoyenneClasseText;
        private System.Windows.Forms.DataGridView dataGridConsultNotes;
    }
}