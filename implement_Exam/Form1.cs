using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace implement_Exam
{
    public partial class Form1 : Form
    {
        static string chaine = @"Data Source=DESKTOP-IOMF4D2\MSSQLSERVER02 ;Initial Catalog=Examen;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        bool estQsm;
        string whatClicked;
        public Form1()
        {
            InitializeComponent();
        }
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
            string qry = "SELECT count(*) FROM " + table + " where idepreuve = " + cbxEpreuve.SelectedValue + ";";
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


        private void Form1_Load(object sender, EventArgs e)
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


            turn_On_Off(btnAdd, true);
            turn_On_Off(btnSave, false);
            turn_On_Off(btnCancel, false);

            txtenonce.Enabled = true;
            numericUpDownNote.Enabled = true;
            radioQsm.Enabled = true;
            radioQSouverte.Enabled = true;

            if (TableQSIsEmpty("question"))
            {
                cbxQuestion.Enabled = false;
                turn_On_Off(btnModify, false);
                turn_On_Off(btnDelete, false);
            }
            else
            {
                turn_On_Off(btnModify, true);
                turn_On_Off(btnDelete, true);
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            turn_On_Off(btnAdd, false);
            turn_On_Off(btnModify, false);
            turn_On_Off(btnDelete, false);
            turn_On_Off(btnSave, true);
            turn_On_Off(btnCancel, true);

            cbxQuestion.Enabled = false;
            txtenonce.Enabled = true;
            numericUpDownNote.Enabled = true;
            radioQsm.Enabled = true;
            radioQSouverte.Enabled = true;

            whatClicked = "add";
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            turn_On_Off(btnAdd, false);
            turn_On_Off(btnModify, false);
            turn_On_Off(btnDelete, false);
            turn_On_Off(btnSave, true);
            turn_On_Off(btnCancel, true);

            cbxQuestion.Enabled = true;
            txtenonce.Enabled = true;
            numericUpDownNote.Enabled = true;
            radioQsm.Enabled = true;
            radioQSouverte.Enabled = true;

            whatClicked = "modify";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            turn_On_Off(btnAdd, false);
            turn_On_Off(btnModify, false);
            turn_On_Off(btnDelete, false);
            turn_On_Off(btnSave, true);
            turn_On_Off(btnCancel, true);

            cbxQuestion.Enabled = true;
            txtenonce.Enabled = false;
            numericUpDownNote.Enabled = false;
            radioQsm.Enabled = false;
            radioQSouverte.Enabled = false;

            whatClicked = "delete";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            turn_On_Off(btnSave, false);
            turn_On_Off(btnCancel, false);
            turn_On_Off(btnModify, true);
            turn_On_Off(btnDelete, true);

            txtenonce.Enabled = true;
            numericUpDownNote.Enabled = true;
            radioQsm.Enabled = true;
            radioQSouverte.Enabled = true;

            if (whatClicked == "add")
            {
                string ennonce = txtenonce.Text;
                int note = int.Parse(numericUpDownNote.Value.ToString());


                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "insert into question( ennonce,noteQs,idEpreuve,type ) values('" + ennonce + " '," + note + "," + cbxEpreuve.SelectedValue + ",'" + estQsm + "')";
                cmd.ExecuteNonQuery();
                cnx.Close();

            }
            if (whatClicked == "modify")
            {
                string ennonce = txtenonce.Text;
                int note = int.Parse(numericUpDownNote.Value.ToString());


                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = " update question set ennonce ='" + txtenonce.Text + "', noteQs = " + numericUpDownNote.Value + ",type = '" + estQsm + "' where id= " + cbxQuestion.SelectedValue + " ;";
                cmd.ExecuteNonQuery();
                cnx.Close();
                txtenonce.Clear();
            }
            if (whatClicked == "delete")
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "delete from question where id =" + cbxQuestion.SelectedValue + " ";
                cmd.ExecuteNonQuery();
                cnx.Close();
            }


            txtenonce.Clear();
            numericUpDownNote.Value = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            turn_On_Off(btnAdd, true);
            turn_On_Off(btnSave, false);
            turn_On_Off(btnCancel, false);
            turn_On_Off(btnModify, true);
            turn_On_Off(btnDelete, true);

            txtenonce.Enabled = true;
            numericUpDownNote.Enabled = true;
            radioQsm.Enabled = true;
            radioQSouverte.Enabled = true;
            txtenonce.Clear();
            numericUpDownNote.Value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbxEpreuve_SelectedIndexChanged(object sender, EventArgs e)
        {
            turn_On_Off(btnAdd, true);

            cnx.Close();
            string query2 = "select ennonce, id from question where idepreuve=" + cbxEpreuve.SelectedValue + " ;";
            cmd.CommandText = query2;
            cnx.Open();
            SqlDataAdapter drd2 = new SqlDataAdapter(query2, cnx);
            DataSet ds2 = new DataSet();
            drd2.Fill(ds2, "ennonce");
            cbxQuestion.DisplayMember = "ennonce";
            cbxQuestion.ValueMember = "id";
            cbxQuestion.DataSource = ds2.Tables["ennonce"];
            cnx.Close();

            if (TableQSIsEmpty("question"))
            {
                cbxQuestion.Enabled = false;
                turn_On_Off(btnModify, false);
                turn_On_Off(btnDelete, false);
            }
            else
            {
                turn_On_Off(btnModify, true);
                turn_On_Off(btnDelete, true);
            }
        }

        private void cbxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LblAddReponses_Click(object sender, EventArgs e)
        {

        }

        private void txtenonce_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxType_Enter(object sender, EventArgs e)
        {

        }

        private void radioQsm_CheckedChanged(object sender, EventArgs e)
        {
            estQsm = true;
        }

        private void radioQSouverte_CheckedChanged(object sender, EventArgs e)
        {
            estQsm = false;
        }
    }

}