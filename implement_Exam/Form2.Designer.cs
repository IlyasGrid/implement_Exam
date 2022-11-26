namespace implement_Exam
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblCreationEpreuve = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMatiere = new System.Windows.Forms.TextBox();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.LblMatiere = new System.Windows.Forms.Label();
            this.LblDuree = new System.Windows.Forms.Label();
            this.LblNoteTotal = new System.Windows.Forms.Label();
            this.LblDateEpreuve = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LblCreationEpreuve
            // 
            this.LblCreationEpreuve.AutoSize = true;
            this.LblCreationEpreuve.Font = new System.Drawing.Font("Andalus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LblCreationEpreuve.Location = new System.Drawing.Point(229, 9);
            this.LblCreationEpreuve.Name = "LblCreationEpreuve";
            this.LblCreationEpreuve.Size = new System.Drawing.Size(290, 55);
            this.LblCreationEpreuve.TabIndex = 0;
            this.LblCreationEpreuve.Text = "creation Epreuve";
            this.LblCreationEpreuve.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.DarkGray;
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(173, 385);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(141, 53);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(451, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 53);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMatiere
            // 
            this.txtMatiere.Location = new System.Drawing.Point(139, 110);
            this.txtMatiere.Name = "txtMatiere";
            this.txtMatiere.Size = new System.Drawing.Size(150, 31);
            this.txtMatiere.TabIndex = 3;
            this.txtMatiere.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(138, 163);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(150, 31);
            this.txtDuree.TabIndex = 4;
            this.txtDuree.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(139, 213);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(150, 31);
            this.txtNote.TabIndex = 5;
            this.txtNote.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // LblMatiere
            // 
            this.LblMatiere.AutoSize = true;
            this.LblMatiere.Location = new System.Drawing.Point(30, 113);
            this.LblMatiere.Name = "LblMatiere";
            this.LblMatiere.Size = new System.Drawing.Size(71, 25);
            this.LblMatiere.TabIndex = 6;
            this.LblMatiere.Text = "Matiere";
            this.LblMatiere.Click += new System.EventHandler(this.LblMatiere_Click);
            // 
            // LblDuree
            // 
            this.LblDuree.AutoSize = true;
            this.LblDuree.Location = new System.Drawing.Point(30, 163);
            this.LblDuree.Name = "LblDuree";
            this.LblDuree.Size = new System.Drawing.Size(59, 25);
            this.LblDuree.TabIndex = 7;
            this.LblDuree.Text = "Duree";
            this.LblDuree.Click += new System.EventHandler(this.LblDuree_Click);
            // 
            // LblNoteTotal
            // 
            this.LblNoteTotal.AutoSize = true;
            this.LblNoteTotal.Location = new System.Drawing.Point(30, 216);
            this.LblNoteTotal.Name = "LblNoteTotal";
            this.LblNoteTotal.Size = new System.Drawing.Size(88, 25);
            this.LblNoteTotal.TabIndex = 8;
            this.LblNoteTotal.Text = "NoteTotal";
            this.LblNoteTotal.Click += new System.EventHandler(this.LblNoteTotal_Click);
            // 
            // LblDateEpreuve
            // 
            this.LblDateEpreuve.AutoSize = true;
            this.LblDateEpreuve.Location = new System.Drawing.Point(30, 269);
            this.LblDateEpreuve.Name = "LblDateEpreuve";
            this.LblDateEpreuve.Size = new System.Drawing.Size(112, 25);
            this.LblDateEpreuve.TabIndex = 9;
            this.LblDateEpreuve.Text = "DateEpreuve";
            this.LblDateEpreuve.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(161, 269);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker.TabIndex = 11;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.LblDateEpreuve);
            this.Controls.Add(this.LblNoteTotal);
            this.Controls.Add(this.LblDuree);
            this.Controls.Add(this.LblMatiere);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.txtMatiere);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblCreationEpreuve);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblCreationEpreuve;
        private Button BtnSave;
        private Button btnCancel;
        private TextBox txtMatiere;
        private TextBox txtDuree;
        private TextBox txtNote;
        private Label LblMatiere;
        private Label LblDuree;
        private Label LblNoteTotal;
        private Label LblDateEpreuve;
        private DateTimePicker dateTimePicker;
    }
}