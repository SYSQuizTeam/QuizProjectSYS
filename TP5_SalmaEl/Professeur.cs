using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_SalmaEl
{
   public  class Professeur
    {
        //Attributes
        private string ID;
        private string nomP;
        private string prenomP;



        //Properties
        public string ID1 { get => ID; set => ID = value; }
        public string NomP { get => nomP; set => nomP = value; }
        public string PrenomP { get => prenomP; set => prenomP = value; }



           // Constructeur 

        public Professeur(string iD, string nomP, string prenomP)
        {
            ID = iD;
            this.nomP = nomP;
            this.prenomP = prenomP;
        }


        //Constructeur par defaut

            public Professeur() { }

        //Fonction qui convert un objet a un disctionnaire ( puisqu'on a utilise un dictionnaire dans la classe Sql)
        public Dictionary<string, object> ConverObjectToDictionnary()
        {
            Dictionary<string, object> prof = new Dictionary<string, object>();

            prof.Add("ID", ID1);
            prof.Add("nomP", NomP);
            prof.Add("prenomP", PrenomP);
           

            return prof;

        }
    }
}

