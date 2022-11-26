using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implement_Exam.csEpreuve
{
    public class Reponse
    {
        bool verite;
        string rps;
        double certitude;
        public Reponse() { }
        public Reponse(bool verite, string rps)
        {
            this.verite = verite;
            this.rps = rps;
        }

        public bool Verite { get { return verite; } set { verite = value; } }
        public string StrRepons { get { return rps; } set { rps = value; } }
        public double Certitude
        {
            get { return certitude; }
        }


        public void enterCertitude(bool sur)
        {
            if (sur == true)
                certitude = 100;
            else
            {
                certitude = 50;
            }
        }

    }
}
