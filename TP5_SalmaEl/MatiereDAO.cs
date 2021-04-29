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
    class MatiereDAO : DAO, IDAO<Matiere>
    {
        public MatiereDAO(string table) : base(table)
        {
            
        }

        public int Delete(string conditions)
        {
            return base.delete(conditions);
        }

        public int insert(Matiere M)
        {
            return base.insert(M.ConverObjectToDictionnary());
        }

        public int update(Matiere M, string req)
        {
            return base.update(req, M.ConverObjectToDictionnary());
        }

        

        public ArrayList select(string req)
        {
            List<Dictionary<string, string>> Liste = base.select(req);
            ArrayList Matieres = new ArrayList();
            foreach (Dictionary<string, string> dico in Liste)
            {
                Matiere M = new Matiere
                {
                    CodeMat = dico["codeMat"],
                    Designation = dico["designation"],
                    Coeff = float.Parse(dico["coeff"]),
                    CodeModul = dico["codeModule"],
                    RespMat1 = dico["RespMat"],
                };
                Matieres.Add(M);

            }
            return Matieres;
        }
    }
}
