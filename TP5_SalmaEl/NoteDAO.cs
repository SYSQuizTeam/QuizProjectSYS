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
    public class NoteDAO : DAO, IDAO<Note>
    {
        public NoteDAO(string table) : base(table)
        {
            
        }

        public int Delete(string conditions)
        {
            return base.delete(conditions);
        }
        public int insert(Note M)
        {
            return base.insert(M.ConverObjectToDictionnary());
        }

        public int update(Note M, string req)
        {
            return base.update(req, M.ConverObjectToDictionnary());
        }

        public ArrayList select(string req)
        {
            List<Dictionary<string, string>> Liste = base.select(req);
            ArrayList Notes = new ArrayList();
            foreach (Dictionary<string, string> dico in Liste)
            {
                Note M = new Note
                {
                    CodeElev = dico["codeElev"],
                    CodeMat = dico["codeMat"],
                    Note1 = int.Parse(dico["note"]),
                };
                Notes.Add(M);
            }
            return Notes;
        }


        /*public int insertProc()
        {
            return base.insert2("AJOUTER");
        }*/
    }
}
