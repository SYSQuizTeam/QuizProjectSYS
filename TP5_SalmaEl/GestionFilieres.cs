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
    public partial class GestionFilieres : Form
    {
        DataTable tableF = new DataTable();
        FiliereDAO F = new FiliereDAO("filiere");


        public GestionFilieres()
        {
            InitializeComponent();
            ChargerTableF();
        }

        private void GestionFilieres_Load(object sender, EventArgs e)
        {
            FillTableF("");  // select * from filiere
        }



        private void ChargerTableF()
        {
            try
            {
                DataColumn c0 = new DataColumn("CodeFiliere");
                DataColumn c1 = new DataColumn("Designation");
                //DataColumn c2 = new DataColumn("Niveaux");


                tableF.Columns.Add(c0);
                tableF.Columns.Add(c1);
               // tableF.Columns.Add(c2);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }





        private void FillTableF(string conditions)
        {
            tableF.Clear();
            if (conditions != "")  // A  Select with 'where'
            {
                ArrayList filieres = F.select(conditions);
                //.select(conditions);
                foreach (Filiere element in filieres)
                {
                    DataRow row = tableF.NewRow();
                    row[0] = element.Code;
                    row[1] = element.Designation;
                    //row[2] = element.Niveaux;

                    tableF.Rows.Add(row);
                }
            }
            else
            {

                ArrayList filieres = F.select("");  // A simple Select without clause Where
                foreach (Filiere element in filieres)
                {
                    DataRow row = tableF.NewRow();
                    row[0] = element.Code;
                    row[1] = element.Designation;
                    //row[2] = element.Niveaux;

                    tableF.Rows.Add(row);
                }
            }
            //set table
            dataGridFilieres.DataSource = tableF;
        }

        private void AjouterF_Click(object sender, EventArgs e)
        {
            //ajouter
            string cod = CodeFText.Text;
            string des = DesText.Text;
            //string niv = NivT.Text;
            

            if (cod != "" && des != "" /*&& niv != ""*/)
            {
                try
                {
                    Filiere Fil = new Filiere(cod, des /*,Int32.Parse(niv)*/);
                    F.insert(Fil);
                    MessageBox.Show("Filiere bien ajoutée");
                    FillTableF("");
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

        private void ModifierF_Click(object sender, EventArgs e)
        {
            string cod = CodeFText.Text;
            string des = DesText.Text;
           // string niv = NivT.Text;



            Filiere Fil = new Filiere(cod, des /*, Int32.Parse(niv)*/);
            F.update(Fil, new RequestCondition("codeF").Equal(cod));
            FillTableF("");
        }

        private void SupprimerF_Click(object sender, EventArgs e)
        {
            string cod = CodeFText.Text;
            F.delete(new RequestCondition("codeF").Equal(cod));
            FillTableF("");
        }

        private void RechercherF_Click(object sender, EventArgs e)
        {
            string Conditions = "";
           
            Conditions += new RequestCondition("codeF").Equal(CodeFText);
           
            tableF.Clear();
            FillTableF(Conditions);
        }
    }
}
