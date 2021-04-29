using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using SqlLibrary;

namespace TP5_SalmaEl
{
    public class ProfesseurDAO : DAO, IDAO<Professeur>
    {
        public ProfesseurDAO(string table) : base(table)
        {

        }

        public int insert(Professeur P)
        {
            return base.insert(P.ConverObjectToDictionnary());
        }

        public int Delete(string conditions)
        {
            return base.delete(conditions);
        }

        public int update(Professeur P, String conditions)
        {
            return base.update(conditions, P.ConverObjectToDictionnary());
        }





        public ArrayList selectProfs()  // pour select only name of professeur
        {
            List<Dictionary<string, string>> R = base.select("");
            ArrayList Profs = new ArrayList();
            foreach (var D in R)
            {

                Profs.Add(D["nomP"]);

            }
            return Profs;

        }




        public ArrayList select(string RequestCondition)
        {
            List<Dictionary<string, string>> Liste = base.select(RequestCondition);
            ArrayList Profs = new ArrayList();
            foreach (Dictionary<string, string> dico in Liste)
            {
                foreach (var pair in dico)
                    Console.WriteLine(pair.Key);

                Professeur P = new Professeur();
                P.ID1 = dico["ID"];
                P.NomP = dico["nomP"];
                P.PrenomP = dico["prenomP"];

                Profs.Add(P);

            }
            return Profs;
        }
    }
}

