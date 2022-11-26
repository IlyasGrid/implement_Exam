using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implement_Exam.csEpreuve
{
    internal class Examinateur
    {
        string nom;
        string prenom;
        int id;


        public Examinateur(string nom, string prenom, int id)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.id = id;
        }
        public string lastName { get { return nom; } set { nom = value; } }
        public string firstName { get { return prenom; } set { prenom = value; } }
        public int Id { get { return id; } set { id = value; } }
    }

}
