using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Add class library :

using SqlLibrary;

namespace TP5_SalmaEl
{
    public class Note
    {
        //Attributs
        private string codeElev;
        private string codeMat;
        private float note;

        //GETTERS and SETTERS
        public string CodeElev { get => codeElev; set => codeElev = value; }
        public string CodeMat { get => codeMat; set => codeMat = value; }
        public float Note1 { get => note; set => note = value; }


        //CSTR
        public Note(string codeElev, string codeMat, float note)
        {
            this.codeElev = codeElev;
            this.codeMat = codeMat;
            this.note = note;
        }

        //CSTR PAR DEFAUT
        public Note() { }


        //CONVERT TO DICTIONNARY
        public Dictionary<string, object> ConverObjectToDictionnary()
        {
            Dictionary<string, object> Dnote = new Dictionary<string, object>();

            Dnote.Add("codeElev", codeElev);
            Dnote.Add("codeMat", codeMat);
            Dnote.Add("note", note);
            return Dnote;
        }


    }
}
