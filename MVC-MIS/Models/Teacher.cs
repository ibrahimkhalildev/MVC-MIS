using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MVC_MIS.Models
{
    public class Teacher
    {
        public string TeacherName { get; set; }
        public string CouseName {  get; set; }
        public int CourseId {  get; set; }

        public static List<Teacher> GetTeacher()
        {
            List<Teacher> TeacherList = new List<Teacher>();

            Teacher teacher = new Teacher();

            teacher.TeacherName = "Abdur Rahim";
            teacher.CouseName = "C# with Dot net Core";
            teacher.CourseId = 561;
            TeacherList.Add(teacher);


            return TeacherList;
        }


    }
}