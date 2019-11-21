namespace Student_form_management
{
    partial class Create_Student
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
            this.lbCode = new System.Windows.Forms.Label();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.lbHomeTown = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rtbHomeTown = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(13, 13);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(32, 13);
            this.lbCode.TabIndex = 0;
            this.lbCode.Text = "Code";
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(68, 10);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(151, 20);
            this.txbCode.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 41);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(68, 41);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(151, 20);
            this.txbName.TabIndex = 3;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(13, 82);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(42, 13);
            this.lbGender.TabIndex = 4;
            this.lbGender.Text = "Gender";
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(68, 82);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(48, 17);
            this.rdMale.TabIndex = 5;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(141, 82);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(59, 17);
            this.rdFemale.TabIndex = 6;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // lbHomeTown
            // 
            this.lbHomeTown.AutoSize = true;
            this.lbHomeTown.Location = new System.Drawing.Point(13, 138);
            this.lbHomeTown.Name = "lbHomeTown";
            this.lbHomeTown.Size = new System.Drawing.Size(65, 13);
            this.lbHomeTown.TabIndex = 7;
            this.lbHomeTown.Text = "Home Town";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(113, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // rtbHomeTown
            // 
            this.rtbHomeTown.Location = new System.Drawing.Point(14, 155);
            this.rtbHomeTown.Name = "rtbHomeTown";
            this.rtbHomeTown.Size = new System.Drawing.Size(205, 83);
            this.rtbHomeTown.TabIndex = 23;
            this.rtbHomeTown.Text = "";
            // 
            // Create_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 283);
            this.Controls.Add(this.rtbHomeTown);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbHomeTown);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.lbCode);
            this.Name = "Create_Student";
            this.Text = "Create_Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.Label lbHomeTown;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox rtbHomeTown;
    }
}