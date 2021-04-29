using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Collections;

// Add class library :

using SqlLibrary;

namespace TP5_SalmaEl
{
    public class EleveDAO : DAO, IDAO<Eleve>
    {
        public EleveDAO(string table) : base(table)
        {

        }

        public int insert(Eleve M)
        {
            return base.insert(M.ConverObjectToDictionnary());
        }

        public int Delete(string conditions)
        {
            return base.delete(conditions);
        }

        public int update(Eleve M, String conditions)
        {
            return base.update(conditions, M.ConverObjectToDictionnary());
        }

        public ArrayList select(string RequestCondition)
        {
            List<Dictionary<string, string>> Liste = base.select(RequestCondition);
            ArrayList Eleves = new ArrayList();
            foreach (Dictionary<string, string> dico in Liste)
            {
                foreach (var pair in dico)
                    Console.WriteLine(pair.Key);

                Eleve E = new Eleve();
                E.CodeElev1 = dico["codeElev"];
                E.Code_Fil= dico["code_Fil"];
                E.Nom = dico["nom"];
                E.Niveau = dico["niveau"];
                E.Prenom = dico["prenom"];
                Eleves.Add(E);

            }
            return Eleves;
        }
    }
}
