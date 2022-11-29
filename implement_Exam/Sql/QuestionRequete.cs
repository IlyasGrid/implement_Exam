using implement_Exam.csEpreuve;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implement_Exam.Sql
{
    public class QuestionRequete
    {
        /* la connection   */
        static string chaine = @"Data Source=DESKTOP-IOMF4D2\MSSQLSERVER02 ;Initial Catalog=Examen;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapterEpreuve = new SqlDataAdapter(cmd);

        string ennonce;
        int noteQuestion;
        public string Ennonce { get { return ennonce; } set { ennonce = value; } }
        public int NoteQuestion { get { return noteQuestion; } set { noteQuestion = value; } }
        public void insertQuestion(string ennonce, int note, bool estQsm, int idEpreuve)
        {
            cnx.Close();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into question( ennonce,noteQs,idEpreuve,type ) values('" + ennonce + " '," + note + "," + idEpreuve + ",'" + estQsm + "')";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public void updateQuestion(string ennonce, int note, bool typeQS, int idQuestion)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = " update question set ennonce ='" + ennonce + "', noteQs = " + note + ",type = '" + typeQS + "' where id= " + idQuestion + " ;";
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void deleteQuestion(int idQuestion)
        {

            cnx.Close();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from question where id =" + idQuestion + " ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public bool isQcm(int idQuestion)
        {
            cnx.Close();
            bool estqcm;
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "select type from question where id= " + idQuestion + ";";
            estqcm = (bool)cmd.ExecuteScalar();
            cnx.Close();

            return estqcm;
        }

        public bool TableQSIsEmpty(int IdEpreuve)
        {

            cnx.Open();
            string qry = "SELECT count(*) FROM question where idepreuve = " + IdEpreuve + ";";
            SqlCommand comd = new SqlCommand(qry, cnx);
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
                cnx.Close();
            }
            cnx.Close();
        }
        public bool TableReponseIsEmpty(int IdQs)
        {
            cnx.Close();
            cnx.Open();
            string qry = "SELECT count(*) FROM qsm where id_question = " + IdQs + ";";
            SqlCommand comd = new SqlCommand(qry, cnx);
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
                cnx.Close();
            }
            cnx.Close();
        }

        public void fillQuestionCombobox(ComboBox cbx, int idEpreuve)
        {
            cnx.Close();
            cnx.Open();

            string query2 = "select ennonce, id from question where idepreuve=" + idEpreuve + " ;";
            cmd.CommandText = query2;

            SqlDataAdapter drd2 = new SqlDataAdapter(query2, cnx);
            DataSet ds2 = new DataSet();
            drd2.Fill(ds2, "ennonce");
            cbx.DisplayMember = "ennonce";
            cbx.ValueMember = "id";
            cbx.DataSource = ds2.Tables["ennonce"];
            cnx.Close();
        }
        public void fillEpreuveCombobox(ComboBox cbxEpreuve)
        {
            string query = "select matiere, id from epreuve";
            cmd.CommandText = query;
            cnx.Open();
            SqlDataAdapter drd = new SqlDataAdapter(query, cnx);
            DataSet ds = new DataSet();
            drd.Fill(ds, "matiere");
            cbxEpreuve.DisplayMember = "matiere";
            cbxEpreuve.ValueMember = "id";
            cbxEpreuve.DataSource = ds.Tables["matiere"];
            cnx.Close();
        }

    }
}
