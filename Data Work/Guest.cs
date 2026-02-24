using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptForUser
{
    internal class Guest : User, ISpeaker
    {
        private string card_id;
        private string majer;
        private string workplace;
        private string position;

        public void setId(string id)
        {
            card_id = id;
        }
        public string getStudent_id()
        {
            return card_id;
        }
        public void setMajer(string majer)
        {
            this.majer = majer;
        }

        public void setWorkplace(string workplace)
        {
            this.workplace = workplace;
        }

        public void setPosition(string position)
        {
            this.position = position;
        }

        // ISpeaker implementation
        public void Train()
        {
            Console.WriteLine($"Guest {Firstname} {lastname} is training.");
        }

        public void Approve(User trainee)
        {
            Console.WriteLine($"Guest {Firstname} {lastname} approved training for {trainee.getFirstname()}.");
        }

    }
}