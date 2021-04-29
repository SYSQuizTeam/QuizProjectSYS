
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Add class library :

using SqlLibrary;

namespace TP5_SalmaEl
{
    public partial class GestionNotes : Form
    {

        ModuleDAO MDD = new ModuleDAO("module");
        EleveDAO E = new EleveDAO("eleves");
        MatiereDAO M = new MatiereDAO("matieres");
        NoteDAO ND = new NoteDAO("notes2021");
        SqlConnection con;
        SqlCommand cmd;

        //con = new MySqlConnection(@"server=localhost;user id=root;database=gestionnotes2021");
       // con.Open();
        //MySqlCommand cmd = new MySqlCommand();

        SqlDataReader dr;
        SqlCommand cd;

       

        public GestionNotes()
        {
            InitializeComponent();
        }


        public GestionNotes(string code)
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source= DESKTOP-CMMGAAS\SQLEXPRESS; Initial Catalog = gestionnotes2021; Integrated Security = True");
            
            con.Open();
            cmd = new SqlCommand();

            CodeText.Text = code;
            CodeText.Enabled = false;
            lesMatiere(code);

        }


        private void GestionNotes_Load(object sender, EventArgs e)
        {
            
        }


        private void lesMatiere(string code)   // pour charger les matieres qui etudie un etudiant! (a revoir !!)
        {

            ArrayList L = E.select(new RequestCondition("codeElev").Equal(code));
            foreach (Eleve V in L)
            {
                ArrayList F = MDD.select(new RequestCondition("Cod_Fil").Equal(V.Code_Fil));
                foreach (Module mod in F)
                {
                    ArrayList Mat = M.select(new RequestCondition("codeModule").Equal(mod.Designation1));
                    foreach (Matiere MT in Mat)
                    {
                        MatiereCombo.Items.Add(MT.Designation);
                    }
                }
            }

        }


        private void ViderChamps()
        {
            MatiereCombo.Text = "";
            NoteTexte.Text = "";
        }


        private void Nouveau_Click(object sender, EventArgs e)
        {
            ViderChamps();
        }



       /*private void CodeText_TextChanged(object sender, EventArgs e)
        {
            lesMatiere(CodeText.Text);
        }*/




            // Function Ajouter sans utiliser la procédure Stocké :
        private void Ajouter_Click(object sender, EventArgs e)
        {

            //Ajouter sans utiliser la procédure Stocké :
            /*string code = CodeText.Text;
            string mat = MatiereCombo.Text;
            float note = float.Parse(NoteTexte.Text);



            if (code != " " && mat != " " && note >= 0 && note <=20)
            {
                try
                {
                    Note N = new Note(code, mat, note);

                    ND.insert(N);
                    MessageBox.Show("Note bien ajouté");
                    ViderChamps();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs ou s'assurer que la note est compris entre 0 et 20");
            }*/


            AJOUTER();
        }



        //function Ajouter en utilisant la procedure stocké  
        
        public void AJOUTER()
        {
            string code = CodeText.Text;
            string mat = MatiereCombo.Text;
            float note = float.Parse(NoteTexte.Text);



            if (code != " " && mat != " " && note >= 0 && note <= 20)
            {
                try
                {
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "NT_AJOUT";
                    cmd.Parameters.Add("@CodeElev", SqlDbType.VarChar,20).Value = code;
                    cmd.Parameters.Add("@CodeMat", SqlDbType.VarChar,20).Value = mat;
                    cmd.Parameters.Add("@Note", SqlDbType.Float).Value = note;

                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Note bien ajouté");
                    ViderChamps();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs ou s'assurer que la note est compris entre 0 et 20");
            }

        }




        private void Modifier_Click(object sender, EventArgs e)
        {
            /*string code = CodeText.Text;
            string mat = MatiereCombo.Text;
            float note = float.Parse(NoteTexte.Text);

            if (code != "" && mat != "" && note >= 0 && note <= 20)
            {
                try
                {
                    Note N = new Note(code, mat, note);
                    ND.update(N, new RequestCondition("codeElev").Equal(code) + "and" + new RequestCondition("codeMat").Equal(mat));
                    MessageBox.Show("Note bien Modifier");

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs ou s'assurer que la note est compris entre 0 et 20");
            }*/

            MODIFIER();
        }






        // Function Modifier en utilisant la procédure Stocké :
        public void MODIFIER()
        {
            string code = CodeText.Text;
            string mat = MatiereCombo.Text;
            float note = float.Parse(NoteTexte.Text);


            if(code != " " && mat != " " && note >= 0 && note <= 20)
            {
                try
                {
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "NT_UPDATE";
                    cmd.Parameters.Add("@Note", SqlDbType.Float).Value = note;
                    cmd.Parameters.Add("@CodeElev", SqlDbType.VarChar, 20).Value = code;
                    cmd.Parameters.Add("@CodeMat", SqlDbType.VarChar, 20).Value = mat;
                    

                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Note bien Modifier");
                    ViderChamps();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs ou s'assurer que la note est compris entre 0 et 20");
            }


        }














        //  // Function Supprimer sans utiliser la procédure Stocké :
        private void Supprimer_Click(object sender, EventArgs e)
        {
            //Supprimer sans utiliser la procédure Stocké :

            /* string code = CodeText.Text;
             string mat = MatiereCombo.Text;
             float note = float.Parse(NoteTexte.Text);

             ND.delete(new RequestCondition("codeElev").Equal(code) + "and" + new RequestCondition("codeMat").Equal(mat));
             MessageBox.Show("Note bien Supprimé");
             ViderChamps();*/

            SUPPRIMER();
        }





        // Function Supprimer en utilisant la procédure Stocké :
        public void SUPPRIMER()
        {
            string code = CodeText.Text;
            string mat = MatiereCombo.Text;
            float note = float.Parse(NoteTexte.Text);


                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "NT_DELETE";
                    cmd.Parameters.Add("@CodeElev", SqlDbType.VarChar, 20).Value = code;
                    cmd.Parameters.Add("@CodeMat", SqlDbType.VarChar, 20).Value = mat;
                  
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Note bien Supprimé");
                    ViderChamps();
   
        }








        private void Rechercher_Click(object sender, EventArgs e)
        {
            string code = CodeText.Text;
            string mat = MatiereCombo.Text;
            ArrayList L = ND.select(new RequestCondition("codeElev").Equal(code) + "and" + new RequestCondition("codeMat").Equal(mat));
            foreach (Note N in L)
            {
                NoteTexte.Text = N.Note1.ToString();
            }
        }
    }
}
