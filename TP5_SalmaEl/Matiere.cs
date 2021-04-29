using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Add class library :

using SqlLibrary;
namespace TP5_SalmaEl
{
   public class Matiere  //la classe matiere ici depend de la classe Module et a pour caracteristique son coeff et dans quel modul elle existe ?
    {
        //LEs attributs
        private string codeMat;
        private string designation;
        private double coeff;
        private string codeModul;
        private string RespMat;

        //Getters and Setters
        public string CodeMat { get => codeMat; set => codeMat = value; }
        public string Designation { get => designation; set => designation = value; }
        public double Coeff { get => coeff; set => coeff = value; }
        public string CodeModul { get => codeModul; set => codeModul = value; }
        public string RespMat1 { get => RespMat; set => RespMat = value; }


        //CSTR pour changer tout les fields of matiere
        public Matiere(string codeMat=null, string designation=null, double coeff=0, string codeModul=null,string RespMat=null) 
        {
            this.codeMat = codeMat;
            this.designation = designation;
            this.coeff = coeff;
            this.codeModul = codeModul;
            this.RespMat = RespMat;
        }


        //Cstr pour changer la designation 
        /*public Matiere(string codeMat, object designation)
        {
            
        }*/
/*
        //Cstr pour changer la designation 
        public Matiere(string codeMat,string coeff)
        {
            this.coeff = coeff;
        }
        */

        // CSTR PAR DEFAUT
        public Matiere() { }


        // COnvert To Dictionnary
        public Dictionary<string, object> ConverObjectToDictionnary()
        {
            Dictionary<string, object> matiere = new Dictionary<string, object>();

            matiere.Add("codeMat", codeMat);
            matiere.Add("designation", designation);
            matiere.Add("coeff", coeff);
            matiere.Add("codeModule", codeModul);
            matiere.Add("RespMat", RespMat);
            return matiere;
        }


       


    }
}
