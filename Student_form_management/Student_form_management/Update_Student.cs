using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_form_management
{
    public partial class Update_Student : Form
    {
        private StudentManagement business;
        private int FindID;
        public Update_Student(int id)
        {
            InitializeComponent();
            this.business = new StudentManagement();
            FindID = id;
            this.Load += Update_Student_Load;
            this.btnSave.Click += BtnSave_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }
        private bool CheckGender()
        {
            bool gender;
            if (rdFemale.Checked)
            {
                gender = false;
            }
            else
            {
                gender = true;
            }
            return gender;
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var code = txbCode.Text;
            var name = txbName.Text;
            var gender = CheckGender();
            var hometown = rtbHomeTown.Text;
            this.business.EditStudent(this.FindID, code, name, gender, hometown);
            this.Dispose();
        }

        private void Update_Student_Load(object sender, EventArgs e)
        {
            var students = this.business.GetStudent(FindID);
            txbCode.Text = students.Code;
            txbName.Text = students.Name;
            if (students.Gender == true)
            {
                this.rdMale.Checked = true;
            }
            else
                this.rdFemale.Checked = true;
            rtbHomeTown.Text = students.Hometown;
        }
    }
}
