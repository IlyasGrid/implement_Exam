using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implement_Exam.Sql
{
    public class ReponseRequete
    {
        /* la connection   */
        static string chaine = @"Data Source=DESKTOP-IOMF4D2\MSSQLSERVER02 ;Initial Catalog=Examen;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapterEpreuve = new SqlDataAdapter(cmd);

        string reponse;
        bool verite;

        public string Reponse { get { return reponse; } set { reponse = value; } }
        public bool Verite { get { return verite; } set { verite = value; } }

        public void insertReponse(string reponse, bool VoF, int idQuestion)
        {
            cnx.Close();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Qsm( reponse,verite,id_question ) values('" + reponse + " '," + VoF + "," + idQuestion + ")";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public void updateReponse(string str_reponse, bool VoF, int idReponse)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = " update qsm set reponse ='" + str_reponse + "', verite = '" + VoF + "' where id= " + idReponse + " ;";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public void deleteReponse(int idReponse)
        {

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from qsm where id = " + idReponse + " ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public void fillCombobox(ComboBox cbx)
        {
            string query2 = "select ennonce, id from question where question.type=1";
            cmd.CommandText = query2;
            cnx.Open();
            SqlDataAdapter drd2 = new SqlDataAdapter(query2, cnx);
            DataSet ds2 = new DataSet();
            drd2.Fill(ds2, "ennonce");
            cbx.DisplayMember = "ennonce";
            cbx.ValueMember = "id";
            cbx.DataSource = ds2.Tables["ennonce"];
            cnx.Close();
        }
        public void fillReponseCombobox(ComboBox cbxRp, ComboBox cbxQs)
        {
            cnx.Close();
            cnx.Open();
            string query2 = "select qsm.reponse, qsm.id from qsm inner join question ON question.id = qsm.id_question  where   question.type =1  and id_question=" + cbxQs.SelectedValue + ";";
            cmd.CommandText = query2;
            SqlDataAdapter drd2 = new SqlDataAdapter(query2, cnx);
            DataSet ds2 = new DataSet();
            drd2.Fill(ds2, "reponse");
            cbxRp.DisplayMember = "reponse";
            cbxRp.ValueMember = "id";
            cbxRp.DataSource = ds2.Tables["reponse"];
            cnx.Close();
        }

    }
}
