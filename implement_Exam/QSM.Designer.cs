﻿namespace implement_Exam
{
    partial class QSM
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
            this.cbxQS = new System.Windows.Forms.ComboBox();
            this.cbxRp = new System.Windows.Forms.ComboBox();
            this.txtRp = new System.Windows.Forms.TextBox();
            this.lblQS = new System.Windows.Forms.Label();
            this.lblReponse = new System.Windows.Forms.Label();
            this.lblAddRps = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFaux = new System.Windows.Forms.RadioButton();
            this.radioVrai = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxQS
            // 
            this.cbxQS.FormattingEnabled = true;
            this.cbxQS.Location = new System.Drawing.Point(110, 33);
            this.cbxQS.Name = "cbxQS";
            this.cbxQS.Size = new System.Drawing.Size(321, 33);
            this.cbxQS.TabIndex = 0;
            this.cbxQS.SelectedIndexChanged += new System.EventHandler(this.cbxQS_SelectedIndexChanged);
            // 
            // cbxRp
            // 
            this.cbxRp.FormattingEnabled = true;
            this.cbxRp.Location = new System.Drawing.Point(110, 84);
            this.cbxRp.Name = "cbxRp";
            this.cbxRp.Size = new System.Drawing.Size(493, 33);
            this.cbxRp.TabIndex = 1;
            this.cbxRp.SelectedIndexChanged += new System.EventHandler(this.cbxRp_SelectedIndexChanged);
            // 
            // txtRp
            // 
            this.txtRp.Location = new System.Drawing.Point(190, 142);
            this.txtRp.Name = "txtRp";
            this.txtRp.Size = new System.Drawing.Size(366, 31);
            this.txtRp.TabIndex = 2;
            // 
            // lblQS
            // 
            this.lblQS.AutoSize = true;
            this.lblQS.Location = new System.Drawing.Point(12, 36);
            this.lblQS.Name = "lblQS";
            this.lblQS.Size = new System.Drawing.Size(84, 25);
            this.lblQS.TabIndex = 3;
            this.lblQS.Text = "Question";
            // 
            // lblReponse
            // 
            this.lblReponse.AutoSize = true;
            this.lblReponse.Location = new System.Drawing.Point(12, 87);
            this.lblReponse.Name = "lblReponse";
            this.lblReponse.Size = new System.Drawing.Size(88, 25);
            this.lblReponse.TabIndex = 4;
            this.lblReponse.Text = "Rsponses";
            // 
            // lblAddRps
            // 
            this.lblAddRps.AutoSize = true;
            this.lblAddRps.Location = new System.Drawing.Point(12, 142);
            this.lblAddRps.Name = "lblAddRps";
            this.lblAddRps.Size = new System.Drawing.Size(161, 25);
            this.lblAddRps.TabIndex = 5;
            this.lblAddRps.Text = "AddReponses here";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(224, 310);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(112, 34);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(417, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(664, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(664, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(133, 386);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(316, 34);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "return to questions";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFaux);
            this.groupBox1.Controls.Add(this.radioVrai);
            this.groupBox1.Location = new System.Drawing.Point(135, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 59);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrai ou faux";
            // 
            // radioFaux
            // 
            this.radioFaux.AutoSize = true;
            this.radioFaux.Location = new System.Drawing.Point(199, 27);
            this.radioFaux.Name = "radioFaux";
            this.radioFaux.Size = new System.Drawing.Size(70, 29);
            this.radioFaux.TabIndex = 1;
            this.radioFaux.TabStop = true;
            this.radioFaux.Text = "faux";
            this.radioFaux.UseVisualStyleBackColor = true;
            // 
            // radioVrai
            // 
            this.radioVrai.AutoSize = true;
            this.radioVrai.Location = new System.Drawing.Point(3, 27);
            this.radioVrai.Name = "radioVrai";
            this.radioVrai.Size = new System.Drawing.Size(65, 29);
            this.radioVrai.TabIndex = 0;
            this.radioVrai.TabStop = true;
            this.radioVrai.Text = "vrai";
            this.radioVrai.UseVisualStyleBackColor = true;
            // 
            // QSM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAddRps);
            this.Controls.Add(this.lblReponse);
            this.Controls.Add(this.lblQS);
            this.Controls.Add(this.txtRp);
            this.Controls.Add(this.cbxRp);
            this.Controls.Add(this.cbxQS);
            this.Name = "QSM";
            this.Text = "QSM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QSM_FormClosing);
            this.Load += new System.EventHandler(this.QSM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxQS;
        private ComboBox cbxRp;
        private TextBox txtRp;
        private Label lblQS;
        private Label lblReponse;
        private Label lblAddRps;
        private Button btnAdd;
        private Button btnModify;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private Button btnReturn;
        private GroupBox groupBox1;
        private RadioButton radioFaux;
        private RadioButton radioVrai;
    }
}