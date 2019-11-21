using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_form_management
{
    class StudentView
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Hometown { get; set; }

        public StudentView(int id, string code, string name, string gender, string hometown)
        {
            this.ID = id;
            this.Code = code;
            this.Name = name;
            this.Gender = gender;
            this.Hometown = hometown;
        }
    }
}
