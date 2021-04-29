using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Add class library :

using SqlLibrary;


namespace TP5_SalmaEl
{
    public partial class Consultation_Des_Notes : Form
    {
        DataTable tableN = new DataTable();
        ArrayList LF;
        ModuleDAO MD = new ModuleDAO("module");
        MatiereDAO MTD = new MatiereDAO("matieres");
        EleveDAO E = new EleveDAO("eleves");
        NoteDAO N = new NoteDAO("notes2021");


        public Consultation_Des_Notes()
        {
            InitializeComponent();
            loadF();
            ChargerTable();
        }









        private void ChargerTable()
        {
            try
            {
                DataColumn c0 = new DataColumn("Code Eleve");
                DataColumn c1 = new DataColumn("Nom");
                DataColumn c2 = new DataColumn("Prenom");
                DataColumn c3 = new DataColumn("Note");

                tableN.Columns.Add(c0);
                tableN.Columns.Add(c1);
                tableN.Columns.Add(c2);
                tableN.Columns.Add(c3);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }




    
        private void FillTable(string fil, string niv, string mat)
        {
            // pour calculer Moyenne de classe
            int nbrEleves = 0;
            float sum = 0;

            //vider la table pour eviter la redondance
            tableN.Clear();

            if (fil != "" && niv != "" && mat != "")
            {
                ArrayList eleves = E.select(new RequestCondition("niveau").Equal(niv));

                foreach (Eleve element in eleves)
                {
                    ArrayList notes = N.select(new RequestCondition("codeElev").Equal(element.CodeElev1));
                    foreach (Note n in notes)
                    {
                        if (n.CodeMat.Equals(mat))
                        {
                            DataRow row = tableN.NewRow();
                            row[0] = element.CodeElev1;
                            row[1] = element.Nom;
                            row[2] = element.Prenom;
                            row[3] = n.Note1;
                            tableN.Rows.Add(row);

                            // Pour calculer la moyenne de la classe à la fin
                            nbrEleves++;
                            sum += n.Note1;
                        }
                    }
                }
                MoyenneClasseText.Text = (sum / nbrEleves).ToString();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            dataGridConsultNotes.DataSource = tableN;
        }








        private void loadN(String ch)
        {
            NiveauCombo.Items.Clear();
            string[] AP = { "AP1", "AP2" };
            string[] GINF = { "GINF1", "GINF2", "GINF3" };
            string[] GSTR = { "GSTR1", "GSTR2", "GSTR3" };
            string[] GSEA = { "GSEA1", "GSEA2", "GSEA3" };
            string[] G3EI = { "G3EI1", "G3EI2", "G3EI3" };
            string[] GIND = { "GIND1", "GIND2", "GIND3" };
            string[] L = null;
            switch (ch)
            {
                case "AP":
                    L = AP;
                    break;
                case "GINF":
                    L = GINF;
                    break;
                case "GSTR":
                    L = GSTR;
                    break;
                case "GSEA":
                    L = GSEA;
                    break;
                case "G3EI":
                    L = G3EI;
                    break;
                case "GIND":
                    L = GIND;
                    break;
                default:
                    L = new string[1];
                    L[0] = "";
                    break;
            }
            foreach (string n in L)
            {
                NiveauCombo.Items.Add(n);

            }

        }
        private void loadM(String niv)
        {
            ArrayList M = MD.select(new RequestCondition("niveau").Equal(niv));
            foreach (Module m in M)
            {
                ArrayList MAT = MTD.select(new RequestCondition("codeModule").Equal(m.Designation1));
                foreach (Matiere mat in MAT)
                {
                    MatiereCombo.Items.Add(mat.Designation);
                    
                }
            }
        }



        private void loadF()
        {
            LF = new FiliereDAO("filiere").selectfiliere();
            foreach (string f in LF)
            {
                FiliereCombo.Items.Add(f);
            }
        }






        // To show niveau of a particular filiere
        private void FiliereCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (FiliereCombo.SelectedIndex != 0)
            {
                loadN((string)FiliereCombo.SelectedItem);
            }
        }


        // To show Matiere of a particular niveau
        private void NiveauCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //NiveauCombo.Text = "";
            if (NiveauCombo.SelectedIndex == 0)
            {
                loadM((string)NiveauCombo.SelectedItem);
            }
            else {
                MatiereCombo.Items.Clear();
                loadM((string)NiveauCombo.SelectedItem);
            }
        }











        private void Consultation_Des_Notes_Load(object sender, EventArgs e)
        {

        }

        private void RechercherBtn_Click(object sender, EventArgs e)
        {
            FillTable(FiliereCombo.Text, NiveauCombo.Text, MatiereCombo.Text);
        }
    }
}
