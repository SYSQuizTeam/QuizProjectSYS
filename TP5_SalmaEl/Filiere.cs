using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Add class library :

using SqlLibrary;

namespace TP5_SalmaEl
{
    public class Filiere
    {
        private string code;
        private string designation;
       // private int niveaux;


        public string Code { get => code; set => code = value; }
        public string Designation { get => designation; set => designation = value; }
       // public int Niveaux { get => niveaux; set => niveaux = value; }

        public Filiere(string c = null, string d = null /*, int n = 0*/)
        {
            code = c;
            designation = d;
           // niveaux = n;
        }
        public Filiere() { }

        public Dictionary<string, object> ConverObjectToDictionnary()
        {
            Dictionary<string, object> filiere = new Dictionary<string, object>();

            filiere.Add("codeF", code);
            filiere.Add("designation", designation);
            //filiere.Add("niveaux", niveaux);
            return filiere;
        }
    }
}
