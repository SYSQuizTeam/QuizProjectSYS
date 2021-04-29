using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Add class library :

using SqlLibrary;

namespace TP5_SalmaEl
{
    public class FiliereDAO : DAO, IDAO<Filiere>
    {
        public FiliereDAO(string table) : base(table)
        {
        }

        public int Delete(string req)
        {
            return base.delete(req);
        }

        public int insert(Filiere M)
        {
            return base.insert(M.ConverObjectToDictionnary());
        }

        public ArrayList selectfiliere()  // pour select only name of filiere
        {
            List<Dictionary<string, string>> R = base.select("");
            ArrayList Filieres = new ArrayList();
            foreach (var D in R)
            {

                Filieres.Add(D["designation"]);

            }
            return Filieres;

        }

        /*public ArrayList selectNiveaux(string codFiliere)  // pour select les niveaux qui existe dans une filiere
        {
            List<Dictionary<string, string>> R = base.selectNivF(codFiliere);
            ArrayList FilieresNiv = new ArrayList();
            foreach (var D in R)
            {

                FilieresNiv.Add(D);

            }
            return FilieresNiv;
            

        }*/

        public int update(Filiere M, string req)
        {
            return base.update(req, M.ConverObjectToDictionnary());
        }

        public ArrayList select(string req = "")
        {
            List<Dictionary<string, string>> Liste = base.select(req);
            ArrayList filiers = new ArrayList();
            foreach (Dictionary<string, string> dico in Liste)
            {
                Filiere Fil = new Filiere();
                Fil.Code = dico["codeF"];
                Fil.Designation = dico["designation"];
               // Fil.Niveaux = Int32.Parse(dico["niveaux"]);

                filiers.Add(Fil);

            }
            return filiers;
        }
    }
}
