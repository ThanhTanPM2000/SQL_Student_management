using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_form_management
{
    class StudentManagement
    {
        public PM20569[] GetStudent()
        {
            var db = new OOPCS2Entities();
            var students = db.PM20569.ToArray();
            return students;
        }

        public PM20569 GetStudent(int id)
        {
            var db = new OOPCS2Entities();
            var students = db.PM20569.Find(id);
            return students;
        }

        public void AddStudent(string code, string name, bool gender, string HomeTown)
        {
            var students = new PM20569();
            students.Code = code;
            students.Name = name;
            students.Gender = gender;
            students.Hometown = HomeTown;

            var db = new OOPCS2Entities();
            db.PM20569.Add(students);
            db.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var db = new OOPCS2Entities();
            var students = db.PM20569.Find(id);
            db.PM20569.Remove(students);
            db.SaveChanges();
        }

        public void EditStudent(int id, string code, string name, bool gender, string HomeTown)
        {
            var db = new OOPCS2Entities();
            var student = db.PM20569.Find(id);
            student.Code = code;
            student.Name = name;
            student.Gender = gender;
            student.Hometown = HomeTown;

            db.Entry(student).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        
            
        
    }
}
