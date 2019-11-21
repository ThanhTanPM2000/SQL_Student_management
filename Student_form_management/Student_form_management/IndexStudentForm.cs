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
    public partial class IndexStudentForm : Form
    {
        private StudentManagement business;
        public IndexStudentForm()
        {
            InitializeComponent();
            this.business = new StudentManagement();
            this.Load += IndexStudentForm_Load;
            this.btnADDSTUDENT.Click += BtnADDSTUDENT_Click;
            this.btnDELETESTUDENT.Click += BtnDELETESTUDENT_Click;
            this.grdStudent.DoubleClick += GrdStudent_DoubleClick;
            
        }

        private void GrdStudent_DoubleClick(object sender, EventArgs e)
        {
            if(grdStudent.SelectedRows.Count == 1)
            {
                int id = int.Parse(this.grdStudent.SelectedRows[0].Cells[0].Value.ToString());
                var UpdateForm = new Update_Student(id);
                UpdateForm.ShowDialog();
                LoadAllStudent();
            }
        }

        private void LoadAllStudent()
        {
            var students = this.business.GetStudent();
            StudentView[] list = new StudentView[students.Length];
            for (int i = 0; i < list.Length; i++)
            {
                PM20569 obj = students[i];
                list[i] = new StudentView(obj.ID, obj.Code, obj.Name, !obj.Gender ? "female" : "male", obj.Hometown);
            }
            this.grdStudent.DataSource = list;
        }
        private void BtnDELETESTUDENT_Click(object sender, EventArgs e)
        {
            if(grdStudent.SelectedRows.Count == 1)
            {
                if((MessageBox.Show("Bạn có chắc xóa phần này không", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    int id = int.Parse(this.grdStudent.SelectedRows[0].Cells[0].Value.ToString());
                    this.business.DeleteStudent(id);
                    MessageBox.Show("Xóa thành công");
                    LoadAllStudent();
                }
            }
        }
        private void BtnADDSTUDENT_Click(object sender, EventArgs e)
        {
            var CreateForm = new Create_Student();
            CreateForm.ShowDialog();
            LoadAllStudent();
        }

        private void IndexStudentForm_Load(object sender, EventArgs e)
        {
            LoadAllStudent();
        }
    }
}
