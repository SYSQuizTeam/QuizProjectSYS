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
    public partial class Bilan_Annuel : Form
    {
        DataTable tableB = new DataTable();

        public Bilan_Annuel()
        {
            InitializeComponent();
            loadF();
            ChargerTable();
        }

        private void Bilan_Annuel_Load(object sender, EventArgs e)
        {

        }



        private void ChargerTable()
        {
            try
            {
                DataColumn c0 = new DataColumn("code Matiere");
                DataColumn c1 = new DataColumn("Designation");
                DataColumn c2 = new DataColumn("Semestre");
                DataColumn c3 = new DataColumn("note");
                tableB.Columns.Add(c0);
                tableB.Columns.Add(c1);
                tableB.Columns.Add(c2);
                tableB.Columns.Add(c3);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }






        private void loadF()
        {
            ArrayList LF = new FiliereDAO("filiere").select();
            foreach (Filiere f in LF)
            {
                FiliereCombo.Items.Add(f.Designation);
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


        private void LoadEtudiants(string niveau)
        {
            EleveDAO ed = new EleveDAO("eleves");
            ArrayList Et = ed.select(new RequestCondition("niveau").Equal(niveau));
            foreach (Eleve E in Et)
            {
                EtudiantCombo.Items.Add(E.CodeElev1);
            }
        }






        private void FiliereCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiliereCombo.SelectedIndex != 0)
            {
                loadN((string)FiliereCombo.SelectedItem);
            }
        }

      

        private void NiveauCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NiveauCombo.SelectedIndex != 0)
            {
                LoadEtudiants((string)NiveauCombo.SelectedItem);
            }
            else
            {
                EtudiantCombo.Items.Clear();
                LoadEtudiants((string)NiveauCombo.SelectedItem);
            }
        }





       








        private void FillTable(string E)
        {
            tableB.Clear();
            int i = 0;
            double n = 0;
            float moyenne = 0;
            NoteDAO ND = new NoteDAO("notes2021");
            MatiereDAO MD = new MatiereDAO("matieres");
            ModuleDAO MOD = new ModuleDAO("module");
            Matiere Mati = new Matiere();


            /*  ArrayList Notes = ND.select(new RequestCondition("codeElev").Equal(E));
              foreach (Note no in Notes)
              {
                  ArrayList MAT = MD.select(new RequestCondition("designation").Equal(no.CodeMat));
                  foreach (Matiere mat in MAT)
                  {
                      ArrayList Mod = MOD.select(new RequestCondition("codeModul").Equal(mat.CodeModul));
                      foreach(Module mod in Mod)
                      {
                          DataRow row = tableB.NewRow();
                          row[0] = mat.CodeMat;
                          row[1] = mat.Designation;
                          row[2] = mod.Semestre1;
                          row[3] = no.Note1;
                          tableB.Rows.Add(row);

                          n += (mat.Coeff * no.Note1) / 100;
                          i++;
                      }
                      */



            ArrayList Notes = ND.select(new RequestCondition("codeElev").Equal(E));
            foreach (Note element in Notes)
            {
                DataRow row = tableB.NewRow();
                row[1] = element.CodeMat;
                row[3] = element.Note1;
                tableB.Rows.Add(row);
                ArrayList MT = MD.select(new RequestCondition("designation").Equal(element.CodeMat));
                foreach (Matiere M in MT)
                {
                    row[0] = M.CodeMat;
                    n += (M.Coeff * element.Note1);
                    i++;

                    ArrayList Mod = MOD.select(new RequestCondition("Designation").Equal(M.CodeModul));
                    foreach (Module mod in Mod)
                    {
                        row[2] = mod.Semestre1;
                    }
                }
               



                }

            dataGridBilanAnnuel.DataSource = tableB;
            moyenne = ((float)n / i);
            MoyenneAnnText.Text = moyenne.ToString();

      //  }
            


           /* ArrayList Notes = ND.select(new RequestCondition("codeElev").Equal(E));
            foreach (Note element in Notes)
            {
                DataRow row = tableB.NewRow();
                row[0] = element.CodeMat;
                
                row[2] = element.Note1;
                tableB.Rows.Add(row);
                ArrayList MT = MD.select(new RequestCondition("CodeMat").Equal(element.CodeMat));
                foreach (Matiere M in MT)
                {
                    n += (M.Coeff * element.Note1) / 100;
                    i++;
                }

            }
            */
            


        }

        private void RechercherBtn_Click(object sender, EventArgs e)
        {
            if (!(EtudiantCombo.Text.Equals("")))
            {
                FillTable((string)EtudiantCombo.SelectedItem);
            }
            else
            {
                MessageBox.Show("ffbd");
            }
        }
    }
}
