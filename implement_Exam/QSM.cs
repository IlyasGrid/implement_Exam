using implement_Exam.csEpreuve;
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
using implement_Exam.Sql;
using System.Configuration;

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
        ReponseRequete rpn = new ReponseRequete();



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

            Form1 ins = new Form1();
            ins.Show();
            this.Hide();
        }
        private void cbxQS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxRp.Enabled = true;
            rpn.fillReponseCombobox(cbxRp, cbxQS);

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
            rpn.fillCombobox(cbxQS);

            turn_On_Off(btnAdd, true);
            turn_On_Off(btnDelete, false);
            turn_On_Off(btnModify, false);
            turn_On_Off(btnSave, false);
            turn_On_Off(btnCancel, false);


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
                string repon = txtRp.Text;
                rpn.insertReponse(repon, estVrai, (int)cbxQS.SelectedValue);
            }
            if (whatclicked == "modify")
            {
                string rp = txtRp.Text;

                rpn.updateReponse(rp, estVrai, (int)cbxRp.SelectedValue);
                txtRp.Clear();
            }
            if (whatclicked == "delete")
            {
                rpn.deleteReponse((int)cbxRp.SelectedValue);
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

        private void QSM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void radioVrai_CheckedChanged(object sender, EventArgs e)
        {
            estVrai = true;
        }

        private void radioFaux_CheckedChanged(object sender, EventArgs e)
        {
            estVrai = false;
        }
    }
}
