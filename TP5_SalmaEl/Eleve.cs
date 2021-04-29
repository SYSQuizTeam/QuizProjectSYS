using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Add class library :

using SqlLibrary;

namespace TP5_SalmaEl
{
    public class Eleve // must to be public ! 
    {
        //Attributes
        private string CodeElev;
        private string nom;
        private string prenom;
        private string code_Fil;
        private string niveau;
       




        //Properties
        public string CodeElev1 { get => CodeElev; set => CodeElev = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Niveau { get => niveau; set => niveau = value; }
        public string Code_Fil { get => code_Fil; set => code_Fil = value; }


        //Constructor
        public Eleve(string code, string nom = null, string prenom = null, string code_Fil = null, string niveau = null) // hado initianilisahom f null bash mni nbghiw n modifiiw n9Dro nselectiw an eleve by his id only
        {
            //new dao();
            CodeElev = code;
            Nom = nom;
            Prenom = prenom;
            Code_Fil = code_Fil;
            Niveau = niveau;
            
        }


        // Cstr par Defaut
        public Eleve() { }


        //Fonction qui convert un objet a un disctionnaire ( puisqu'on a utilise un dictionnaire dans la classe MySql)
        public Dictionary<string, object> ConverObjectToDictionnary()
        {
            Dictionary<string, object> eleve = new Dictionary<string, object>();

            eleve.Add("codeElev", CodeElev);
            eleve.Add("nom", nom);
            eleve.Add("prenom", prenom);
            eleve.Add("code_Fil", code_Fil);
            eleve.Add("niveau", niveau);
            

            return eleve;

        }
    }
}
