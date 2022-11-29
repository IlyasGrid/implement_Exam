using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using implement_Exam.csEpreuve;
using System.Collections;
using implement_Exam.Sql;

namespace implement_Exam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /* list pour stocker les epreuves de databse dans la classe */
        public List<Epreuve> epreuves = new List<Epreuve>();

        EpreuveRequte requete = new();

        static string chaine = @"Data Source=DESKTOP-IOMF4D2\MSSQLSERVER02 ;Initial Catalog=Examen;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        /*  fonction pour verifier ci la table EPREUVE est vide ou plien */


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

        /* pour prendre les epreuves  de database et les entrer dans la list et pour verifier si on a des epreuve pour activer le boutton addreponse  */
        private void Form2_Load(object sender, EventArgs e)
        {


            if (!requete.TableIsEmpty())
            {
                btnAddQuestion.Enabled = true;
            }
            else
            {
                btnAddQuestion.Enabled = false;
            }
        }

        /* txtbox Matiere */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            turn_On_Off(BtnSave, true);
            turn_On_Off(btnCancel, true);
        }

        /* txtbox duree */
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            turn_On_Off(BtnSave, true);
            turn_On_Off(btnCancel, true);
        }

        /* txtbox note */
        private void numericUpDownNOTE_ValueChanged(object sender, EventArgs e)
        {
            turn_On_Off(BtnSave, true);
            turn_On_Off(btnCancel, true);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            turn_On_Off(BtnSave, true);
            turn_On_Off(btnCancel, true);
        }
        /* ouvre la form question pour ajouter des question */
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            txtDuree.Text = "";
            txtMatiere.Text = "";
            numericUpDownNOTE.Value = 0;

            Program.question.Show();
            Program.epreuve.Hide();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            /* if pour assurer que les champs sont remplis  */

            if (String.IsNullOrEmpty(txtDuree.Text) || String.IsNullOrEmpty(txtMatiere.Text) || numericUpDownNOTE.Value == 0)
            {
                BtnSave.Text = "try again";
                BtnSave.BackColor = Color.Red;
            }
            else
            {
                BtnSave.Text = "saved";
                turn_On_Off(btnCancel, false);
                turn_On_Off(BtnSave, false);

                epreuves.Add(new Epreuve(txtMatiere.Text, txtDuree.Text, Convert.ToInt32(numericUpDownNOTE.Value), dateTimePicker.Value.Date));

                /* la requete sql*/
                requete.insertEpreuve(txtDuree.Text, txtMatiere.Text, Convert.ToInt32(numericUpDownNOTE.Value), dateTimePicker.Value.Date);


                btnAddQuestion.Enabled = true;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDuree.Text = "";
            txtMatiere.Text = "";
            numericUpDownNOTE.Value = 0;

            turn_On_Off(btnCancel, false);
            turn_On_Off(BtnSave, false);
        }



        private void LblMatiere_Click(object sender, EventArgs e)
        {

        }
        private void LblDuree_Click(object sender, EventArgs e)
        {

        }
        private void LblNoteTotal_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Leave(object sender, EventArgs e)
        {
            Program.epreuve.Close();
            Program.qcm.Close();
            Program.question.Close();
        }
    }
}
