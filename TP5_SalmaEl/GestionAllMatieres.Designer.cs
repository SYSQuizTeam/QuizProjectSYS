namespace TP5_SalmaEl
{
    partial class GestionAllMatieres
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
            this.dataGridMatiere = new System.Windows.Forms.DataGridView();
            this.desMatT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Nouveau = new System.Windows.Forms.Button();
            this.CoeffText = new System.Windows.Forms.TextBox();
            this.CodeMatText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModulText = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.ResponsableCombo = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatiere)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMatiere
            // 
            this.dataGridMatiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatiere.Location = new System.Drawing.Point(60, 246);
            this.dataGridMatiere.Name = "dataGridMatiere";
            this.dataGridMatiere.Size = new System.Drawing.Size(684, 150);
            this.dataGridMatiere.TabIndex = 50;
            // 
            // desMatT
            // 
            this.desMatT.Location = new System.Drawing.Point(167, 64);
            this.desMatT.Name = "desMatT";
            this.desMatT.Size = new System.Drawing.Size(154, 20);
            this.desMatT.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Modul";
            // 
            // Rechercher
            // 
            this.Rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rechercher.Location = new System.Drawing.Point(591, 120);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(141, 33);
            this.Rechercher.TabIndex = 46;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click_1);
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.Location = new System.Drawing.Point(591, 56);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(141, 35);
            this.Supprimer.TabIndex = 45;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click_1);
            // 
            // Modifier
            // 
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(406, 152);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(141, 32);
            this.Modifier.TabIndex = 44;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click_1);
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Location = new System.Drawing.Point(406, 104);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(141, 33);
            this.Ajouter.TabIndex = 43;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click_1);
            // 
            // Nouveau
            // 
            this.Nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nouveau.Location = new System.Drawing.Point(406, 54);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(141, 35);
            this.Nouveau.TabIndex = 42;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = true;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click_1);
            // 
            // CoeffText
            // 
            this.CoeffText.Location = new System.Drawing.Point(167, 108);
            this.CoeffText.Name = "CoeffText";
            this.CoeffText.Size = new System.Drawing.Size(154, 20);
            this.CoeffText.TabIndex = 41;
            // 
            // CodeMatText
            // 
            this.CodeMatText.Location = new System.Drawing.Point(167, 24);
            this.CodeMatText.Name = "CodeMatText";
            this.CodeMatText.Size = new System.Drawing.Size(154, 20);
            this.CodeMatText.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Coefficient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Designation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Code Matiere";
            // 
            // ModulText
            // 
            this.ModulText.FormattingEnabled = true;
            this.ModulText.Location = new System.Drawing.Point(167, 155);
            this.ModulText.Name = "ModulText";
            this.ModulText.Size = new System.Drawing.Size(154, 21);
            this.ModulText.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Responsable";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(342, 66);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 55;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(342, 111);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 56;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(342, 157);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 57;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(342, 203);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 58;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // ResponsableCombo
            // 
            this.ResponsableCombo.FormattingEnabled = true;
            this.ResponsableCombo.Location = new System.Drawing.Point(167, 200);
            this.ResponsableCombo.Name = "ResponsableCombo";
            this.ResponsableCombo.Size = new System.Drawing.Size(154, 21);
            this.ResponsableCombo.TabIndex = 59;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(342, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 60;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // GestionAllMatieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ResponsableCombo);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ModulText);
            this.Controls.Add(this.dataGridMatiere);
            this.Controls.Add(this.desMatT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.CoeffText);
            this.Controls.Add(this.CodeMatText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionAllMatieres";
            this.Text = "GestionAllMatieres";
            this.Load += new System.EventHandler(this.GestionAllMatieres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatiere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMatiere;
        private System.Windows.Forms.TextBox desMatT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.TextBox CoeffText;
        private System.Windows.Forms.TextBox CodeMatText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ModulText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.ComboBox ResponsableCombo;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}