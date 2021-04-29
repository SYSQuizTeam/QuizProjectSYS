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
    public partial class GestionAllMatieres : Form
    {
        DataTable table = new DataTable();
        ModuleDAO MD = new ModuleDAO("modules");
        MatiereDAO MT = new MatiereDAO("matieres");
        ArrayList LF;
        ArrayList LM;

        public GestionAllMatieres()
        {
            InitializeComponent();
            ChargerTable();
        }

        private void GestionAllMatieres_Load(object sender, EventArgs e)
        {
            FillTable("");
            loadModules();
            loadResponsable();
        }


        private void loadModules()
        {

            LM = new ModuleDAO("module").selectmodules();
            //.selectfiliere();
            foreach (string m in LM)
            {
                ModulText.Items.Add(m);
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


        public GestionAllMatieres(string codeModul)
        {
            InitializeComponent();
            ChargerTable();
        }




        private void ChargerTable()
        {
            try
            {
                DataColumn c0 = new DataColumn("CodMat");
                DataColumn c1 = new DataColumn("Designation");
                DataColumn c2 = new DataColumn("Coefficient");
                DataColumn c3 = new DataColumn("Module");
                DataColumn c4 = new DataColumn("Responsable Mat");

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
                ArrayList Matieres = MT.select(conditions);
                foreach (Matiere element in Matieres)
                {
                    DataRow row = table.NewRow();
                    row[0] = element.CodeMat;
                    row[1] = element.Designation;
                    row[2] = element.Coeff;
                    row[3] = element.CodeModul;
                    row[4] = element.RespMat1;
                    table.Rows.Add(row);
                }
            }
            else
            {
                ArrayList Matieres = MT.select("");
                foreach (Matiere element in Matieres)
                {
                    DataRow row = table.NewRow();
                    row[0] = element.CodeMat;
                    row[1] = element.Designation;
                    row[2] = element.Coeff;
                    row[3] = element.CodeModul;
                    row[4] = element.RespMat1;
                    table.Rows.Add(row);
                }
            }
            //set table
            dataGridMatiere.DataSource = table;
        }


       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        
        private void Rechercher_Click_1(object sender, EventArgs e)
        {
            /* string cod = CodeMatText.Text;
             string Des = desMatT.Text;

             ArrayList L = MT.select(new RequestCondition("codeMat").Equal(cod));
             table.Clear();
             foreach (Matiere element in L)
             {
                 DataRow row = table.NewRow();
                 row[0] = element.CodeMat;
                 row[1] = element.Designation;
                 row[2] = element.Coeff;
                 row[3] = element.CodeModul;
                 row[4] = element.RespMat1;
                 table.Rows.Add(row);
             }
             dataGridMatiere.DataSource = table;*/


            string Conditions = "";

            if (checkBox1.Checked)
                Conditions += new RequestCondition("codeMat").Equal(CodeMatText);


            if (checkBox2.Checked)
            {
                if (Conditions != "")
                    Conditions += " and ";
                Conditions += new RequestCondition("designation").Equal(desMatT.Text);

            }
            if (checkBox3.Checked)
            {
                if (Conditions != "")
                    Conditions += " and ";
                Conditions += new RequestCondition("coeff").Equal(CoeffText.Text);

            }
            if (checkBox4.Checked)
            {
                if (Conditions != "")
                    Conditions += " and ";
                Conditions += new RequestCondition("codeModule").Equal(ModulText.Text);

            }
            if (checkBox5.Checked)
            {
                if (Conditions != "")
                    Conditions += " and ";
                Conditions += new RequestCondition("RespMat").Equal(ResponsableCombo.Text);

            }

           
            table.Clear();
            FillTable(Conditions);
        }

        private void Nouveau_Click_1(object sender, EventArgs e)
        {
            CodeMatText.Text = "";
            desMatT.Text = "";
            CoeffText.Text = "";
            ModulText.Text = "";
            ResponsableCombo.Text = "";
            FillTable("");
        }

        private void Ajouter_Click_1(object sender, EventArgs e)
        {

            string cod = CodeMatText.Text;
            string Des = desMatT.Text;
            double pds = float.Parse(CoeffText.Text);
            string module = ModulText.Text;
            string resp = ResponsableCombo.Text;

            if (cod != "" && Des != "")
            {
                try
                {
                    Matiere E = new Matiere(cod, Des, pds, module,resp);//(string CM, string D, double P, string CMD)
                    MT.insert(E);
                    MessageBox.Show("Matiere bien ajouté");
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

        private void Modifier_Click_1(object sender, EventArgs e)
        {
            string cod = CodeMatText.Text;
            string Des = desMatT.Text;
            double pds = float.Parse(CoeffText.Text);
            string module = ModulText.Text;
            string resp = ResponsableCombo.Text;

                if( cod != null && Des != null && pds != 0 && module != null && resp != null)
                {
                    Matiere E = new Matiere(cod, Des, pds, module, resp);
                    MT.update(E, new RequestCondition("codeMat").Equal(cod));
                    MessageBox.Show("Matiere bien modifié");
                    FillTable("");
                }

                else
                {
                    MessageBox.Show("Veuillez remplir tout les champs !!");
                }
            }

          

            


   
        private void Supprimer_Click_1(object sender, EventArgs e)
        {
            string cod = CodeMatText.Text;


            MT.delete(new RequestCondition("codeMat").Equal(cod));
            FillTable("");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
