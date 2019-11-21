namespace Student_form_management
{
    partial class IndexStudentForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnADDSTUDENT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDELETESTUDENT = new System.Windows.Forms.ToolStripMenuItem();
            this.grdStudent = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnADDSTUDENT,
            this.btnDELETESTUDENT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnADDSTUDENT
            // 
            this.btnADDSTUDENT.Name = "btnADDSTUDENT";
            this.btnADDSTUDENT.Size = new System.Drawing.Size(95, 20);
            this.btnADDSTUDENT.Text = "ADD STUDENT";
            // 
            // btnDELETESTUDENT
            // 
            this.btnDELETESTUDENT.Name = "btnDELETESTUDENT";
            this.btnDELETESTUDENT.Size = new System.Drawing.Size(57, 20);
            this.btnDELETESTUDENT.Text = "DELETE";
            // 
            // grdStudent
            // 
            this.grdStudent.AllowUserToAddRows = false;
            this.grdStudent.AllowUserToDeleteRows = false;
            this.grdStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStudent.Location = new System.Drawing.Point(0, 24);
            this.grdStudent.Name = "grdStudent";
            this.grdStudent.ReadOnly = true;
            this.grdStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStudent.Size = new System.Drawing.Size(715, 426);
            this.grdStudent.TabIndex = 1;
            // 
            // IndexStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.grdStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IndexStudentForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnADDSTUDENT;
        private System.Windows.Forms.ToolStripMenuItem btnDELETESTUDENT;
        private System.Windows.Forms.DataGridView grdStudent;
    }
}

