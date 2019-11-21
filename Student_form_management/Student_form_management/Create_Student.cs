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
    public partial class Create_Student : Form
    {
        private StudentManagement business;
        public Create_Student()
        {
            InitializeComponent();
            this.business = new StudentManagement();
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
            var Code = txbCode.Text;
            var Name = txbName.Text;
            var Gender = CheckGender();
            var hometown = rtbHomeTown.Text;

            this.business.AddStudent(Code, Name, Gender, hometown);
            this.Dispose();
        }

       
    }
}
