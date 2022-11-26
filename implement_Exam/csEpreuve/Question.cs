using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implement_Exam.csEpreuve
{
    public class Question
    {
        string ennonce;
        int noteQuestion;


        public Question() { }
        public Question(string enonce, int note)
        {
            this.ennonce = enonce;
            this.noteQuestion = note;
        }
        public int NoteQuestion
        {
            get { return noteQuestion; }
            set
            {
                noteQuestion = value;
            }
        }
        public string Ennonce
        {
            get { return ennonce; }
            set
            {
                ennonce = value;
            }
        }

    }



    class Qcm : Question
    {
        List<Reponse> choix = new();
        List<Proposition> prop = new();

        public Qcm(string enonce, int note) : base(enonce, note)
        {
        }

        public int NombreChoix
        {
            get { return choix.Count; }
        }
        public List<Reponse> Choix
        {
            get { return choix; }
        }
        public List<Proposition> Prop
        {
            get { return prop; }
        }

        public void AddReponses(Reponse reponse)
        {
            choix.Add(reponse);
        }
        public void AddProposition(Proposition proposition)
        {
            prop.Add(proposition);
        }

    }


    class QuestionOuverte : Question
    {
        Proposition proposition;

        public QuestionOuverte(string enonce, int note) : base(enonce, note)
        {
        }
        public Proposition Proposition
        {
            get { return proposition; }
        }
        public void AddProposition(Proposition proposition)
        {
            this.proposition = Proposition;
        }
    }

}
