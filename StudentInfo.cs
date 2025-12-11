using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2DemoProject
{
    internal class StudentInfo
    {
        //construct
        public StudentInfo()
        {
            
        }

        //properties
        public int StudentID { get; set; }
        public String StudentName { get; set; } 
        public String StudentEmail { get; set; }
        public int StudentPhone { get; set; }

        public String StudentAddress { get; set; }


        //Fields or Attributes

        String schoolName = "ABC School";

      //  int StudentID = 121;
        String studnetName = "John Doe";
        String studentEmail = "";
        int studentPhone = 0000000000;
        String studentAddress = "123 Main St, City, Country";
        bool isEnrolled = true;
        internal int StudenID;

        //Methods or Functions - Logic part

        public String GetStudentDetails()
        {
            return "";
        }
    }
}
