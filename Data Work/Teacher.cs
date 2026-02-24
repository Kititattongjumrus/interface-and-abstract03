using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptForUser
{
    internal class Teacher : User, ISpeaker
    {
        private string Teacher_id;
        private string majer;
        private string rank;

        public void setId(string id)
        {
            Teacher_id = id;
        }
        public string getTeacher_id()
        {
            return Teacher_id;
        }
        public void setMajer(string majer)
        {
            this.majer = majer;
        }

        public void setRank(string rank)
        {
            this.rank = rank;
        }

        // ISpeaker implementation
        public void Train()
        {
            Console.WriteLine($"Teacher {Firstname} {lastname} is training.");
        }

        public void Approve(User trainee)
        {
            Console.WriteLine($"Teacher {Firstname} {lastname} approved training for {trainee.getFirstname()}.");
        }
    }
}