using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implement_Exam.csEpreuve
{
    public class Proposition
    {
        string strPropo;
        public Proposition() { }
        public Proposition(string proposition)
        {
            strPropo = proposition;
        }
        public string proposition { get { return strPropo; } set { strPropo = value; } }

    }
}
