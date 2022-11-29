using implement_Exam.csEpreuve;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using implement_Exam.Sql;

namespace implement_Exam
{
    public partial class Form1 : Form
    {
        static string chaine = @"Data Source=DESKTOP-IOMF4D2\MSSQLSERVER02 ;Initial Catalog=Examen;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        QuestionRequete requete = new QuestionRequete();


        /* pour identifier type de question si il est qcm ou pas*/
        bool estQsm;
        /* pour savoir la derniere button cliquer */
        string whatClicked;
        public Form1()
        {
            InitializeComponent();
        }
        /* fonction pour desactiver les bouttons ou les activer selon le parametre boolean entre */
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





        private void Form1_Load(object sender, EventArgs e)
        {

            requete.fillEpreuveCombobox(cbxEpreuve);


            turn_On_Off(btnAdd, true);
            turn_On_Off(btnSave, false);
            turn_On_Off(btnCancel, false);

            txtenonce.Enabled = false;
            numericUpDownNote.Enabled = false;
            radioQsm.Enabled = false;
            radioQSouverte.Enabled = false;

            if (requete.TableQSIsEmpty((int)cbxEpreuve.SelectedValue))
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

            cbxEpreuve.Enabled = false;
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

            cbxEpreuve.Enabled = true;
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

            cbxEpreuve.Enabled = true;
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
            turn_On_Off(btnAdd, true);

            cbxEpreuve.Enabled = true;
            txtenonce.Enabled = false;
            cbxQuestion.Enabled = true;
            numericUpDownNote.Enabled = false;
            radioQsm.Enabled = false;
            radioQSouverte.Enabled = false;


            if (whatClicked == "add")
            {
                string ennonce = txtenonce.Text;
                int note = int.Parse(numericUpDownNote.Value.ToString());
                int idEpreuve = (int)cbxEpreuve.SelectedValue;

                requete.insertQuestion(ennonce, note, estQsm, idEpreuve);


            }
            if (whatClicked == "modify")
            {
                string ennonce = txtenonce.Text;
                int note = int.Parse(numericUpDownNote.Value.ToString());
                int idQs = (int)cbxQuestion.SelectedValue;
                requete.updateQuestion(ennonce, note, estQsm, idQs);
                txtenonce.Clear();


            }
            if (whatClicked == "delete")
            {

                try
                {
                    int idQS = (int)cbxQuestion.SelectedValue;
                    requete.deleteQuestion(idQS);
                }
                catch
                {
                    lblError.Visible = true;
                }
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

            cbxEpreuve.Enabled = true;
            cbxQuestion.Enabled = true;
            txtenonce.Enabled = false;
            numericUpDownNote.Enabled = false;
            radioQsm.Enabled = false;
            radioQSouverte.Enabled = false;
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
            lblError.Visible = false;
            turn_On_Off(btnAdd, true);
            turn_On_Off(btnDelete, false);
            turn_On_Off(btnModify, false);
            turn_On_Off(btnSave, false);
            turn_On_Off(btnCancel, false);


            requete.fillQuestionCombobox(cbxQuestion, (int)cbxEpreuve.SelectedValue);

            if (requete.TableQSIsEmpty((int)cbxEpreuve.SelectedValue))
            {
                cbxQuestion.Enabled = false;
            }
            else
            {
                cbxQuestion.Enabled = true;
            }
        }

        private void cbxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
            turn_On_Off(btnAdd, true);
            turn_On_Off(btnDelete, true);
            turn_On_Off(btnModify, true);
            turn_On_Off(btnSave, false);
            turn_On_Off(btnCancel, false);



            int idQS = (int)cbxQuestion.SelectedValue;

            if (requete.isQcm(idQS))
            {
                addRps.Visible = true;
            }
            else
            {
                addRps.Visible = false;
            }

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

        private void addRps_Click(object sender, EventArgs e)
        {
            cnx.Close();

            Program.qcm.Show();
            Program.question.Hide();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDeleteEpreuve_Click(object sender, EventArgs e)
        {
            try
            {
                EpreuveRequte req = new EpreuveRequte();
                int idEp = (int)cbxEpreuve.SelectedValue;
                req.deletEpreuve(idEp);

            }
            catch
            {
                lblError.Visible = true;
            }
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }

}