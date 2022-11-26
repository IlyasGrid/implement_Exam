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
            this.txtenonce = new System.Windows.Forms.TextBox();
            this.LblAddEnonce = new System.Windows.Forms.Label();
            this.cbxQuestion = new System.Windows.Forms.ComboBox();
            this.radioQsm = new System.Windows.Forms.RadioButton();
            this.radioQSouverte = new System.Windows.Forms.RadioButton();
            this.groupBoxTypr = new System.Windows.Forms.GroupBox();
            this.numericUpDownNote = new System.Windows.Forms.NumericUpDown();
            this.lblNote = new System.Windows.Forms.Label();
            this.addRps = new System.Windows.Forms.Button();
            this.groupBoxTypr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNote)).BeginInit();
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
            this.Epreuve.Location = new System.Drawing.Point(95, 43);
            this.Epreuve.Name = "Epreuve";
            this.Epreuve.Size = new System.Drawing.Size(75, 25);
            this.Epreuve.TabIndex = 2;
            this.Epreuve.Text = "Epreuve";
            this.Epreuve.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Question";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(25, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 56);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(231, 291);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(154, 56);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(439, 291);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 56);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(659, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 51);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(659, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 51);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtenonce
            // 
            this.txtenonce.BackColor = System.Drawing.Color.White;
            this.txtenonce.Enabled = false;
            this.txtenonce.Location = new System.Drawing.Point(142, 155);
            this.txtenonce.Name = "txtenonce";
            this.txtenonce.Size = new System.Drawing.Size(268, 31);
            this.txtenonce.TabIndex = 12;
            this.txtenonce.TextChanged += new System.EventHandler(this.txtenonce_TextChanged);
            // 
            // LblAddEnonce
            // 
            this.LblAddEnonce.AutoSize = true;
            this.LblAddEnonce.Location = new System.Drawing.Point(12, 155);
            this.LblAddEnonce.Name = "LblAddEnonce";
            this.LblAddEnonce.Size = new System.Drawing.Size(103, 25);
            this.LblAddEnonce.TabIndex = 15;
            this.LblAddEnonce.Text = "AddEnonce";
            this.LblAddEnonce.Click += new System.EventHandler(this.LblAddReponses_Click);
            // 
            // cbxQuestion
            // 
            this.cbxQuestion.BackColor = System.Drawing.Color.White;
            this.cbxQuestion.FormattingEnabled = true;
            this.cbxQuestion.Location = new System.Drawing.Point(185, 79);
            this.cbxQuestion.Name = "cbxQuestion";
            this.cbxQuestion.Size = new System.Drawing.Size(268, 33);
            this.cbxQuestion.TabIndex = 1;
            this.cbxQuestion.SelectedIndexChanged += new System.EventHandler(this.cbxQuestion_SelectedIndexChanged);
            // 
            // radioQsm
            // 
            this.radioQsm.AutoSize = true;
            this.radioQsm.Enabled = false;
            this.radioQsm.Location = new System.Drawing.Point(16, 40);
            this.radioQsm.Name = "radioQsm";
            this.radioQsm.Size = new System.Drawing.Size(77, 29);
            this.radioQsm.TabIndex = 16;
            this.radioQsm.TabStop = true;
            this.radioQsm.Text = "QSM";
            this.radioQsm.UseVisualStyleBackColor = true;
            this.radioQsm.CheckedChanged += new System.EventHandler(this.radioQsm_CheckedChanged);
            // 
            // radioQSouverte
            // 
            this.radioQSouverte.AutoSize = true;
            this.radioQSouverte.Enabled = false;
            this.radioQSouverte.Location = new System.Drawing.Point(16, 78);
            this.radioQSouverte.Name = "radioQSouverte";
            this.radioQSouverte.Size = new System.Drawing.Size(174, 29);
            this.radioQSouverte.TabIndex = 17;
            this.radioQSouverte.TabStop = true;
            this.radioQSouverte.Text = "Question ouverte";
            this.radioQSouverte.UseVisualStyleBackColor = true;
            this.radioQSouverte.CheckedChanged += new System.EventHandler(this.radioQSouverte_CheckedChanged);
            // 
            // groupBoxTypr
            // 
            this.groupBoxTypr.Controls.Add(this.radioQSouverte);
            this.groupBoxTypr.Controls.Add(this.radioQsm);
            this.groupBoxTypr.Location = new System.Drawing.Point(416, 137);
            this.groupBoxTypr.Name = "groupBoxTypr";
            this.groupBoxTypr.Size = new System.Drawing.Size(236, 113);
            this.groupBoxTypr.TabIndex = 18;
            this.groupBoxTypr.TabStop = false;
            this.groupBoxTypr.Text = "type";
            this.groupBoxTypr.Enter += new System.EventHandler(this.groupBoxType_Enter);
            // 
            // numericUpDownNote
            // 
            this.numericUpDownNote.Enabled = false;
            this.numericUpDownNote.Location = new System.Drawing.Point(142, 202);
            this.numericUpDownNote.Name = "numericUpDownNote";
            this.numericUpDownNote.Size = new System.Drawing.Size(180, 31);
            this.numericUpDownNote.TabIndex = 19;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(12, 208);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(48, 25);
            this.lblNote.TabIndex = 20;
            this.lblNote.Text = "note";
            // 
            // addRps
            // 
            this.addRps.Location = new System.Drawing.Point(658, 155);
            this.addRps.Name = "addRps";
            this.addRps.Size = new System.Drawing.Size(112, 59);
            this.addRps.TabIndex = 21;
            this.addRps.Text = "AddReponses";
            this.addRps.UseVisualStyleBackColor = true;
            this.addRps.Visible = false;
            this.addRps.Click += new System.EventHandler(this.addRps_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addRps);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.numericUpDownNote);
            this.Controls.Add(this.groupBoxTypr);
            this.Controls.Add(this.LblAddEnonce);
            this.Controls.Add(this.txtenonce);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTypr.ResumeLayout(false);
            this.groupBoxTypr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNote)).EndInit();
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
        private TextBox txtenonce;
        private Label LblAddEnonce;
        private ComboBox cbxQuestion;
        private RadioButton radioQsm;
        private RadioButton radioQSouverte;
        private GroupBox groupBoxTypr;
        private NumericUpDown numericUpDownNote;
        private Label lblNote;
        private Button addRps;
    }
}