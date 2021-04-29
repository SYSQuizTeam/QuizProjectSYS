using ClosedXML.Excel;
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
    public partial class GestionEtudiantForm : Form
    {
        ArrayList LF;
        ArrayList NF;
        DataTable table = new DataTable();
        EleveDAO dao = new EleveDAO("eleves");

        public GestionEtudiantForm()
        {
            InitializeComponent();
            loadF();
            ChargerTable();
        }

        
        



        private void loadF()
        {

            LF = new FiliereDAO("filiere").selectfiliere();
            //.selectfiliere();
            foreach (string f in LF)
            {
                FiliereCombo.Items.Add(f);
            }
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
                case "AP":    // Why it dosen't work?
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
                    L[0] = "n";
                    break;
            }
            foreach (string n in L)
            {
                NiveauCombo.Items.Add(n);

            }

        }


        private void FiliereCombo_SelectedIndexChanged(object sender, EventArgs e) // c'est l'astuce !! ( make sure to choose the event selectedIndexChanged to this function in the design pattern
        {
            if (FiliereCombo.SelectedIndex != 0)
            {
                loadN((string)FiliereCombo.SelectedItem);
            }
        }


        private void ChargerTable()
        {
            try
            {
                DataColumn c0 = new DataColumn("Code");
                DataColumn c1 = new DataColumn("Nom");
                DataColumn c2 = new DataColumn("Prenom");
                DataColumn c3 = new DataColumn("Niveau");
                DataColumn c4 = new DataColumn("Code filière");


                table.Columns.Add(c0);
                table.Columns.Add(c1);
                table.Columns.Add(c2);
                table.Columns.Add(c3);
                table.Columns.Add(c4);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }



        private void FillTable(string conditions)
        {
            table.Clear();
            if (conditions != "")
            {
                ArrayList eleves = dao.select(conditions);
                //.select(conditions);
                foreach (Eleve element in eleves)
                {
                    DataRow row = table.NewRow();
                    row[0] = element.CodeElev1;
                    row[1] = element.Nom;
                    row[2] = element.Prenom;
                    row[3] = element.Niveau;
                    row[4] = element.Code_Fil;
                    table.Rows.Add(row);
                }
            }
            else
            {

                ArrayList eleves = dao.select("");
                foreach (Eleve element in eleves)
                {
                    DataRow row = table.NewRow();
                    row[0] = element.CodeElev1;
                    row[1] = element.Nom;
                    row[2] = element.Prenom;
                    row[3] = element.Niveau;
                    row[4] = element.Code_Fil;
                    table.Rows.Add(row);
                }
            }
            //set table
            DataGridEtudiants.DataSource = table;
        }









        private void GestionEtudiantForm_Load(object sender, EventArgs e)
        {
            FillTable("");
            //loadF();

            //loadN();


        }

        private void NouveauBtn_Click(object sender, EventArgs e)
        {
            CodeT.Clear();  // pour reinitialiser a simpl Texte we use Clear
            NomT.Clear();
            PrenomT.Clear();
            FiliereCombo.ResetText();
            NiveauCombo.ResetText();  // et pour reinitialiser a combp text we use ResetText()
            checkBox1.Checked = false;  // pour reinitialiser checkbox
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            FillTable("");
        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            //ajouter
            string cod = CodeT.Text;
            string nom = NomT.Text;
            string prenom = PrenomT.Text;
            string filiere = FiliereCombo.Text;
            string niveau = NiveauCombo.Text;

            if (cod != "" && nom != "" && prenom != "")
            {
                try
                {
                    Eleve E = new Eleve(cod, nom, prenom, filiere, niveau);
                    dao.insert(E);
                    MessageBox.Show("Eleve bien ajouté");
                    FillTable("");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            string cod = CodeT.Text;
            string nom = NomT.Text;
            string prenom = PrenomT.Text;
            string filiere = FiliereCombo.Text;
            string niveau = NiveauCombo.Text;

            if(cod != null && nom != null && prenom !=null && filiere!= null && niveau !=null )
            {
                Eleve E = new Eleve(cod, nom, prenom, filiere, niveau);
                dao.update(E, new SqlLibrary.RequestCondition("codeElev").Equal(cod));
                FillTable("");
            }
            else
            {
                MessageBox.Show("veuillez remplir tout les champs !!");
            }
           
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            string cod = CodeT.Text;
           
            dao.delete(new RequestCondition("codeElev").Equal(cod));
            FillTable("");
        }

        private void RechercherBtn_Click(object sender, EventArgs e)
        {
            string Conditions = "";
            if (checkBox1.Checked)
                Conditions += new RequestCondition("codeElev").Equal(CodeT.Text);
            if (checkBox2.Checked)
            {
                if (Conditions != "")
                    Conditions += " and ";
                Conditions += new RequestCondition("nom").Equal(NomT.Text);

            }
            if (checkBox3.Checked)
            {
                if (Conditions != "")
                    Conditions += " and ";
                Conditions += new RequestCondition("prenom").Equal(PrenomT.Text);

            }
            if (checkBox5.Checked)
            {
                if (Conditions != "")
                    Conditions += " and ";
                Conditions += new RequestCondition("niveau").Equal(NiveauCombo.Text);

            }
            if (checkBox4.Checked)
            {
                if (Conditions != "")
                    Conditions += " and ";
                Conditions += new RequestCondition("code_Fil").Equal(FiliereCombo.Text);

            }
            table.Clear();
            FillTable(Conditions);
        }

        private void GesNotesBtn_Click(object sender, EventArgs e)
        {
            if (CodeT.Text.Length == 0)
            {
                MessageBox.Show("Choisir un eleve !!");
            }
            else
            {
                string Conditions = new RequestCondition("codeElev").Equal(CodeT.Text);
                ArrayList list = dao.select(Conditions);
                if (list.Count == 0)
                {
                    MessageBox.Show("Eleve n'existe pas !!");
                }
                else
                {
                    GestionNotes GN = new GestionNotes(CodeT.Text);
                    GN.ShowDialog();
                }

            }
        }

        private void ExcelBtn_Click(object sender, EventArgs e)
        {
           
            using(SaveFileDialog sfd=new SaveFileDialog() {  Filter="Excel Workbook|*.xlsx"})
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(table.Copy(), "eleves");
                            workbook.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("you have successfully exported your data to an excel file !");
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }            
            
            
            
            
            //string cod, nm, pr, niv, cdF;
            //ArrayList eleves = dao.select("");

            /*foreach (Eleve element in eleves)
            { 
                cod = element.CodeElev1;
                nm = element.Nom;
                pr = element.Prenom;
                niv = element.Niveau;
                cdF = element.Code_Fil;
            }*/


              /*  var students = new List<Eleve>()
                {
                    foreach (Eleve element in eleves)
                 {
                    new Eleve() { CodeElev1 = eleves., Nom = element.Nom, Prenom = element.Prenom,
                        Niveau = element.Niveau, Code_Fil = element.Code_Fil }
                    }
                };*/

            }

           /* CreateSpreadSheet(students);
            MessageBox.Show("Fichier Excel bien generer ! ");*/
        
        


        
        




       /* private void CreateSpreadSheet(ArrayList eleves)
        {

        }*/
    }
}
