using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using implement_Exam.csEpreuve;

namespace implement_Exam.csEpreuve
{
    public class Epreuve
    {
        string duree;
        string matiere;
        int noteTotal;
        int idExaminateur;
        DateTime start;
        DateTime end;
        DateTime dateEpreuve = new();
        public List<Question> questions = new List<Question>();

        public Epreuve(string matiere, string duree, int noteTotal, DateTime dateEpreuve)
        {
            this.noteTotal = noteTotal;
            this.dateEpreuve = dateEpreuve;
            this.duree = duree;
            this.matiere = matiere;

        }
        public Epreuve(string matiere, string duree, int idExaminateur, int noteTotal, DateTime dateEpreuve)
        {
            this.noteTotal = noteTotal;
            this.dateEpreuve = dateEpreuve;
            this.duree = duree;
            this.matiere = matiere;
            this.idExaminateur = idExaminateur;

        }

        /*       setters et getters    */

        public List<Question> Questions
        {
            get { return questions; }
        }

        public int NbrQuestion
        {
            get { return questions.Count; }
        }
        public int NoteTotal { get { return noteTotal; } set { noteTotal = value; } }

        public string Matiere { get { return matiere; } set { matiere = value; } }

        public int IdExaminateur { get { return idExaminateur; } set { idExaminateur = value; } }

        public DateTime DateEpreuve { get { return dateEpreuve; } set { dateEpreuve = value; } }

        public string Duree { get { return duree; } set { duree = value; } }

        public DateTime Start { get { return start; } }

        public DateTime End { get { return end; } }


        /*   methode   */
        public void OuvrirEpreuve()
        {
            start = DateTime.Now;
        }
        public void FermerEpreuve()
        {
            end = DateTime.Now;
        }

        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }

    }
}
