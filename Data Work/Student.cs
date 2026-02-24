using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptForUser
{
    internal class Student : User
    {
        //get properties from user class
        // firstname, lastname, email, password,phone number
        private string student_id;
        private string majer;

        public void setId(string id)
        {
            student_id = id;
        }
        public string getStudent_id()
        {
            return student_id;
        }
        public void setMajer(string majer)
        {
            this.majer = majer;
        }
    }
}