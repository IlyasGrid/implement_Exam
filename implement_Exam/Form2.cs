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

namespace implement_Exam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public List<Epreuve> epreuves = new List<Epreuve>();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            turn_On_Off(BtnSave, true);
            turn_On_Off(btnCancel, true);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            turn_On_Off(BtnSave, true);
            turn_On_Off(btnCancel, true);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            turn_On_Off(BtnSave, true);
            turn_On_Off(btnCancel, true);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            turn_On_Off(BtnSave, true);
            turn_On_Off(btnCancel, true);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDuree.Text) || String.IsNullOrEmpty(txtMatiere.Text) || String.IsNullOrEmpty(txtNote.Text))
            {
                BtnSave.Text = "try again";
            }
            else
            {
                BtnSave.Text = "saved";
                turn_On_Off(btnCancel, false);
                turn_On_Off(BtnSave, false);

                epreuves.Add(new Epreuve(txtMatiere.Text, txtDuree.Text, int.Parse(txtNote.Text), dateTimePicker.Value.Date));


                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "insert into Epreuve ( duree,matiere,note,date ) values('" + epreuves.LastOrDefault().Duree + " ','" + epreuves.LastOrDefault().Matiere + "','" + epreuves.LastOrDefault().NoteTotal + "','" + epreuves.LastOrDefault().DateEpreuve + "') ;";
                cmd.ExecuteNonQuery();
                cnx.Close();

                txtDuree.Text = "";
                txtMatiere.Text = "";
                txtNote.Text = "";


                Form1 ins = new Form1();
                ins.MdiParent = this.MdiParent;
                this.Show();
                ins.ShowDialog();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDuree.Text = "";
            txtMatiere.Text = "";
            txtNote.Text = "";

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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
