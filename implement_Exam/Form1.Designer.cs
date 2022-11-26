namespace implement_Exam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxEpreuve = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Epreuve = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxReponses = new System.Windows.Forms.ComboBox();
            this.txtBoxQuestions = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblTypeQuestion = new System.Windows.Forms.Label();
            this.LblAddQuestion = new System.Windows.Forms.Label();
            this.LblAddReponses = new System.Windows.Forms.Label();
            this.cbxQuestion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxEpreuve
            // 
            this.cbxEpreuve.FormattingEnabled = true;
            this.cbxEpreuve.Location = new System.Drawing.Point(185, 40);
            this.cbxEpreuve.Name = "cbxEpreuve";
            this.cbxEpreuve.Size = new System.Drawing.Size(321, 33);
            this.cbxEpreuve.TabIndex = 0;
            this.cbxEpreuve.SelectedIndexChanged += new System.EventHandler(this.cbxEpreuve_SelectedIndexChanged);
            // 
            // Epreuve
            // 
            this.Epreuve.AutoSize = true;
            this.Epreuve.Location = new System.Drawing.Point(12, 40);
            this.Epreuve.Name = "Epreuve";
            this.Epreuve.Size = new System.Drawing.Size(75, 25);
            this.Epreuve.TabIndex = 2;
            this.Epreuve.Text = "Epreuve";
            this.Epreuve.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Question";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(142, 304);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(112, 34);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(278, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(409, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(547, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbxReponses
            // 
            this.cbxReponses.BackColor = System.Drawing.Color.Gray;
            this.cbxReponses.Enabled = false;
            this.cbxReponses.FormattingEnabled = true;
            this.cbxReponses.Location = new System.Drawing.Point(454, 92);
            this.cbxReponses.Name = "cbxReponses";
            this.cbxReponses.Size = new System.Drawing.Size(268, 33);
            this.cbxReponses.TabIndex = 10;
            // 
            // txtBoxQuestions
            // 
            this.txtBoxQuestions.Location = new System.Drawing.Point(142, 154);
            this.txtBoxQuestions.Name = "txtBoxQuestions";
            this.txtBoxQuestions.Size = new System.Drawing.Size(268, 31);
            this.txtBoxQuestions.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 31);
            this.textBox2.TabIndex = 12;
            // 
            // LblTypeQuestion
            // 
            this.LblTypeQuestion.AutoSize = true;
            this.LblTypeQuestion.Location = new System.Drawing.Point(399, 92);
            this.LblTypeQuestion.Name = "LblTypeQuestion";
            this.LblTypeQuestion.Size = new System.Drawing.Size(49, 25);
            this.LblTypeQuestion.TabIndex = 13;
            this.LblTypeQuestion.Text = "Type";
            this.LblTypeQuestion.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LblAddQuestion
            // 
            this.LblAddQuestion.AutoSize = true;
            this.LblAddQuestion.Location = new System.Drawing.Point(12, 160);
            this.LblAddQuestion.Name = "LblAddQuestion";
            this.LblAddQuestion.Size = new System.Drawing.Size(118, 25);
            this.LblAddQuestion.TabIndex = 14;
            this.LblAddQuestion.Text = "AddQuestion";
            // 
            // LblAddReponses
            // 
            this.LblAddReponses.AutoSize = true;
            this.LblAddReponses.Location = new System.Drawing.Point(8, 194);
            this.LblAddReponses.Name = "LblAddReponses";
            this.LblAddReponses.Size = new System.Drawing.Size(122, 25);
            this.LblAddReponses.TabIndex = 15;
            this.LblAddReponses.Text = "AddReponses";
            // 
            // cbxQuestion
            // 
            this.cbxQuestion.BackColor = System.Drawing.Color.Gray;
            this.cbxQuestion.Enabled = false;
            this.cbxQuestion.FormattingEnabled = true;
            this.cbxQuestion.Location = new System.Drawing.Point(102, 92);
            this.cbxQuestion.Name = "cbxQuestion";
            this.cbxQuestion.Size = new System.Drawing.Size(268, 33);
            this.cbxQuestion.TabIndex = 1;
            this.cbxQuestion.SelectedIndexChanged += new System.EventHandler(this.cbxQuestion_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAddReponses);
            this.Controls.Add(this.LblAddQuestion);
            this.Controls.Add(this.LblTypeQuestion);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtBoxQuestions);
            this.Controls.Add(this.cbxReponses);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Epreuve);
            this.Controls.Add(this.cbxQuestion);
            this.Controls.Add(this.cbxEpreuve);
            this.Name = "Form1";
            this.Text = "FormModifyEpreuve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxEpreuve;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label Epreuve;
        private Label label2;
        private Button btnAdd;
        private Button btnModify;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cbxReponses;
        private TextBox txtBoxQuestions;
        private TextBox textBox2;
        private Label LblTypeQuestion;
        private Label LblAddQuestion;
        private Label LblAddReponses;
        private ComboBox cbxQuestion;
    }
}