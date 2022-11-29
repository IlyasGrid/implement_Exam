using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implement_Exam.Sql
{
    public class EpreuveRequte
    {
        string duree;
        string matiere;
        int noteTotal;
        DateTime dateEpreuve = new();

        static string chaine = @"Data Source=DESKTOP-IOMF4D2\MSSQLSERVER02 ;Initial Catalog=Examen;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapterEpreuve = new SqlDataAdapter(cmd);

        public string Duree { get { return duree; } set { duree = value; } }
        public int NoteTotal { get { return noteTotal; } set { noteTotal = value; } }
        public string Matiere { get { return matiere; } set { matiere = value; } }
        public DateTime DateEpreuve { get { return dateEpreuve; } set { dateEpreuve = value; } }

        public void insertEpreuve(string duree, string matiere, int note, DateTime dateEp)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Epreuve ( duree,matiere,note,date ) values('" + duree + " ','" + matiere + "','" + note + "','" + dateEp + "') ;";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public bool TableIsEmpty()
        {

            string qry = "SELECT count(*) FROM epreuve ;";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-IOMF4D2\MSSQLSERVER02 ;Initial Catalog=Examen;Integrated Security=True");
            conn.Open();
            SqlCommand comd = new SqlCommand(qry, conn);
            try
            {
                Int32 count = (Int32)comd.ExecuteScalar();
                if (count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {

            }
            conn.Close();
        }

        public void deletEpreuve(int idEpreuve)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from epreuve where id =" + idEpreuve + " ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

    }
}
