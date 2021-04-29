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
    public partial class GestionModules : Form
    {
        ModuleDAO MD = new ModuleDAO("module");
       // Module M = new Module();
        DataTable tableM = new DataTable();

        public GestionModules()
        {
            InitializeComponent();
            loadSemestre();
            loadF();
            loadResponsable();
            ChargerTable();
        }





        private void loadSemestre()
        {
            SemestreCombo.Items.Clear();

            string[] Semestre = { "S1", "S2", "S3", "S4" };
            foreach (string n in Semestre)
            {
                SemestreCombo.Items.Add(n);

            }
        }


        private void loadResponsable()
        {
            ArrayList LPr = new ProfesseurDAO("Professeurs").selectProfs();
            foreach (string p in LPr)
            {
                ResponsableCombo.Items.Add(p);
            }
        }


        private void loadF()
        {
            ArrayList LF = new FiliereDAO("filiere").selectfiliere();
            foreach (string f in LF)
            {
                FiliereMCombo.Items.Add(f);
            }

        }
        private void loadN(String ch)
        {
            NiceauMCombo.Items.Clear();

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
                NiceauMCombo.Items.Add(n);

            }

        }

        private void FiliereMCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiliereMCombo.SelectedIndex != 0)
            {
                loadN((string)FiliereMCombo.SelectedItem);
            }
        }











        private void ChargerTable()
        {
            try
            {
                DataColumn c0 = new DataColumn("CodeModul");
                DataColumn c1 = new DataColumn("Designation");
                DataColumn c2 = new DataColumn("Filiere");
                DataColumn c3 = new DataColumn("Niveau");
                DataColumn c4 = new DataColumn("Semestre");
                DataColumn c5 = new DataColumn("Responsable");
                DataColumn c6 = new DataColumn("Nombre Matières");


                tableM.Columns.Add(c0);
                tableM.Columns.Add(c1);
                tableM.Columns.Add(c2);
                tableM.Columns.Add(c3);
                tableM.Columns.Add(c4);
                tableM.Columns.Add(c5);
                tableM.Columns.Add(c6);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }



        private void FillTable(string conditions)
        {
            tableM.Clear();
            if (conditions != "")
            {
                ArrayList modules = MD.select(conditions);
                //.select(conditions);
                foreach (Module element in modules)
                {
                    DataRow row = tableM.NewRow();
                    row[0] = element.CodeModul;
                    row[1] = element.Designation1;
                    row[2] = element.Cod_Fil1;
                    row[3] = element.Niveau;
                    row[4] = element.Semestre1;
                    row[5] = element.Responsable1;
                    row[6] = element.NombreMatieres1;
                    tableM.Rows.Add(row);
                }
            }
            else
            {

                ArrayList modules = MD.select("");
                foreach (Module element in modules)
                {
                    DataRow row = tableM.NewRow();
                    row[0] = element.CodeModul;
                    row[1] = element.Designation1;
                    row[2] = element.Cod_Fil1;
                    row[3] = element.Niveau;
                    row[4] = element.Semestre1;
                    row[5] = element.Responsable1;
                    row[6] = element.NombreMatieres1;
                    tableM.Rows.Add(row);
                }
            }
            //set table
            DataGridModules.DataSource = tableM;
        }












        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GestionModules_Load(object sender, EventArgs e)
        {
            FillTable("");
        }

        private void NouveauBtn_Click(object sender, EventArgs e)
        {
            CodeMT.Text = "";
            DesignationT.Text = "";
            FiliereMCombo.Text = "";
            NiceauMCombo.Text = "";
            SemestreCombo.Text = "";
            ResponsableCombo.Text = "";
            NbrMatT.Text = "";
            checkBox1.Checked = false;  // pour reinitialiser checkbox
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            FillTable("");

        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            string code = CodeMT.Text;
            string DES = DesignationT.Text;
            string Fil = FiliereMCombo.Text;
            string Niv = NiceauMCombo.Text;
            string sem = SemestreCombo.Text;
            string resp = ResponsableCombo.Text;
            int nbr = int.Parse(NbrMatT.Text);


            if (code != "" && DES != "" && Fil != "" && Niv != "")
            {
                try
                {

                    Module MOD = new Module(code, DES, Niv, nbr, sem, resp, Fil);
                    MD.insert(MOD);
                    MessageBox.Show("MODULE  bien ajouté");
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
            string code = CodeMT.Text;
            string DES = DesignationT.Text;
            string Fil = FiliereMCombo.Text;
            string Niv = NiceauMCombo.Text;
            string sem = SemestreCombo.Text;
            string resp = ResponsableCombo.Text;
            int nbr = int.Parse(NbrMatT.Text);


            Module MOD = new Module(code, DES, Niv, nbr, sem, resp, Fil);
            MD.update(MOD, new RequestCondition("codeModul").Equal(code));
            FillTable("");
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            string code = CodeMT.Text;
            MD.delete(new RequestCondition("codeModul").Equal(code));
            FillTable("");
        }

        private void RechercherBtn_Click(object sender, EventArgs e)
        {
            string Conditions = "";
            if (checkBox1.Checked)
                Conditions += new RequestCondition("codeModul").Equal(CodeMT);
            if (checkBox2.Checked)
            {
                if (Conditions != "")
                    Conditions += " and ";
                Conditions += new RequestCondition("Designation").Equal(DesignationT.Text);

            }
            if (checkBox4.Checked)
            {
                if (Conditions != "")
                    Conditions += " and ";
                Conditions += new RequestCondition("niveau").Equal(NiceauMCombo.Text);

            }
            if (checkBox7.Checked)
            {
                if (Conditions != "")
                    Conditions += " and ";
                Conditions += new RequestCondition("NombreMatieres").Equal(NbrMatT.Text);

            }
            if (checkBox5.Checked)
            {
                if (Conditions != "")
                    Conditions += " and ";
                Conditions += new RequestCondition("Semestre").Equal(SemestreCombo.Text);

            }

            if (checkBox6.Checked)
            {
                if (Conditions != "")
                    Conditions += " and ";
                Conditions += new RequestCondition("Responsable").Equal(ResponsableCombo.Text);

            }

            if (checkBox3.Checked)
            {
                if (Conditions != "")
                    Conditions += " and ";
                Conditions += new RequestCondition("Cod_Fil").Equal(FiliereMCombo.Text);

            }
            tableM.Clear();
            FillTable(Conditions);
        }

        private void GesMatieresBtn_Click(object sender, EventArgs e)
        {
            if (CodeMT.Text.Length == 0 && DesignationT.Text == null)
            {
                MessageBox.Show("Choisir un Module !!");
            }
            else
            {
                string Conditions = new RequestCondition("codeModul").Equal(CodeMT.Text);
                ArrayList list = MD.select(Conditions);
                if (list.Count == 0)
                {
                    MessageBox.Show("Module n'existe pas !!");
                }
                else
                {
                    GestionMatieres GN = new GestionMatieres(DesignationT.Text);  // Designation of Module
                    GN.ShowDialog();
                }

            }
        }
    }
}
