using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Add class library :

using SqlLibrary;

namespace TP5_SalmaEl
{
    class Module   // on a cree une classe Module qui va englober un ensemble de MAtieres
    {
        private string codeModul;
        private string Designation;
        private string niveau;
        private int NombreMatieres;
        private string Semestre;
        private string Responsable;
        private string Cod_Fil;

        public string CodeModul { get => codeModul; set => codeModul = value; }
        public string Designation1 { get => Designation; set => Designation = value; }
        public string Niveau { get => niveau; set => niveau = value; }
        public int NombreMatieres1 { get => NombreMatieres; set => NombreMatieres = value; }
        public string Semestre1 { get => Semestre; set => Semestre = value; }
        public string Responsable1 { get => Responsable; set => Responsable = value; }
        public string Cod_Fil1 { get => Cod_Fil; set => Cod_Fil = value; }

        public Module(string codeModul, string designation, string niveau, int nombreMatieres, string semestre, string responsable, string cod_Fil)
        {
            this.codeModul = codeModul;
            Designation = designation;
            this.niveau = niveau;
            NombreMatieres = nombreMatieres;
            Semestre = semestre;
            Responsable = responsable;
            Cod_Fil = cod_Fil;
        }


        public Module() { }


        public Dictionary<string, object> ConverObjectToDictionnary()
        {
            Dictionary<string, object> Module = new Dictionary<string, object>();

            Module.Add("codeModul", codeModul);
            Module.Add("Designation", Designation);
            Module.Add("niveau", niveau);
            Module.Add("NombreMatieres", NombreMatieres);
            Module.Add("Semestre", Semestre);
            Module.Add("Responsable", Responsable);
            Module.Add("Cod_Fil", Cod_Fil);
            return Module;
        }
    }
}
