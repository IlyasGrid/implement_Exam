using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace implement_Exam
{
    public partial class QSM : Form
    {
        public QSM()
        {
            InitializeComponent();
        }
        string whatclicked;
        bool estVrai;

        static string chaine = @"Data Source=DESKTOP-IOMF4D2\MSSQLSERVER02 ;Initial Catalog=Examen;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);


        public void turn_On_Off(Button btn, bool b)
        {
            btn.Enabled = b;
            if (b)
            {
                btn.BackColor = Color.White;

            }
            else
            {
                btn.BackColor = Color.Gray;
            }
        }
        public bool TableQSIsEmpty(string table)
        {
            string qry = "SELECT count(*) FROM " + table + " where id_question = " + cbxQS.SelectedValue + ";";
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
                conn.Close();
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            cnx.Close();
            Form1 ins = new Form1();
            ins.MdiParent = this.MdiParent;
            this.Show();
            ins.ShowDialog();
        }

        private void cbxQS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxRp.Enabled = true;

            cnx.Close();
            cnx.Open();
            string query2 = "select reponse, id from qsm where id_question=" + cbxQS.SelectedValue + " ;";
            cmd.CommandText = query2;
            SqlDataAdapter drd2 = new SqlDataAdapter(query2, cnx);
            DataSet ds2 = new DataSet();
            drd2.Fill(ds2, "reponse");
            cbxRp.DisplayMember = "reponse";
            cbxRp.ValueMember = "id";
            cbxRp.DataSource = ds2.Tables["reponse"];
            cnx.Close();

            if (TableQSIsEmpty("qsm"))
            {
                cbxRp.Enabled = false;
                turn_On_Off(btnModify, false);
                turn_On_Off(btnDelete, false);
            }
            else
            {
                turn_On_Off(btnModify, true);
                turn_On_Off(btnDelete, true);
            }
        }

        private void QSM_Load(object sender, EventArgs e)
        {
            string query2 = "select ennonce, id from question ";
            cmd.CommandText = query2;
            cnx.Open();
            SqlDataAdapter drd2 = new SqlDataAdapter(query2, cnx);
            DataSet ds2 = new DataSet();
            drd2.Fill(ds2, "ennonce");
            cbxQS.DisplayMember = "ennonce";
            cbxQS.ValueMember = "id";
            cbxQS.DataSource = ds2.Tables["ennonce"];
            cnx.Close();

        }

        private void cbxRp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            turn_On_Off(btnAdd, false);
            turn_On_Off(btnModify, false);
            turn_On_Off(btnDelete, false);
            turn_On_Off(btnSave, true);
            turn_On_Off(btnCancel, true);

            txtRp.Enabled = true;
            radioFaux.Enabled = true;
            radioVrai.Enabled = true;
            cbxRp.Enabled = false;


            whatclicked = "add";
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

            turn_On_Off(btnAdd, false);
            turn_On_Off(btnModify, false);
            turn_On_Off(btnDelete, false);
            turn_On_Off(btnSave, true);
            turn_On_Off(btnCancel, true);

            txtRp.Enabled = true;
            radioFaux.Enabled = true;
            radioVrai.Enabled = true;
            cbxRp.Enabled = true;

            whatclicked = "modify";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            turn_On_Off(btnAdd, false);
            turn_On_Off(btnModify, false);
            turn_On_Off(btnDelete, false);
            turn_On_Off(btnSave, true);
            turn_On_Off(btnCancel, true);

            txtRp.Enabled = false;
            radioFaux.Enabled = false;
            radioVrai.Enabled = false;
            cbxRp.Enabled = true;

            whatclicked = "delete";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            turn_On_Off(btnSave, false);
            turn_On_Off(btnCancel, false);
            turn_On_Off(btnModify, true);
            turn_On_Off(btnDelete, true);
            turn_On_Off(btnAdd, true);

            txtRp.Enabled = false;
            radioFaux.Enabled = false;
            radioVrai.Enabled = false;
            cbxRp.Enabled = true;

            if (whatclicked == "add")
            {
                string rp = txtRp.Text;


                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "insert into qsm( reponse,verite,id_question ) values('" + rp + "','" + estVrai + "'," + cbxQS.SelectedValue + ")";
                cmd.ExecuteNonQuery();
                cnx.Close();

            }
            if (whatclicked == "modify")
            {
                string rp = txtRp.Text;


                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = " update qsm set reponse ='" + txtRp.Text + "', verite = '" + estVrai + "' where id= " + cbxRp.SelectedValue + " ;";
                cmd.ExecuteNonQuery();
                cnx.Close();
                txtRp.Clear();
            }
            if (whatclicked == "delete")
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "delete from qsm where id =" + cbxRp.SelectedValue + " ";
                cmd.ExecuteNonQuery();
                cnx.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            turn_On_Off(btnAdd, true);
            turn_On_Off(btnSave, false);
            turn_On_Off(btnCancel, false);
            turn_On_Off(btnModify, true);
            turn_On_Off(btnDelete, true);



            txtRp.Enabled = false;
            radioFaux.Enabled = false;
            radioVrai.Enabled = false;
            cbxRp.Enabled = true;
            txtRp.Clear();
        }
    }
}
