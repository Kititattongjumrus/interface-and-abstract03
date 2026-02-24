using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptForUser
{
    public class User
    {
        protected string Firstname;
        protected string lastname;
        protected string phone;
        protected string email;
        protected string password;
        public void register(
            string name,
            string lastname,
            string phone,
            string email,
            string password)
        {
            this.Firstname = name;
            this.lastname = lastname;
            this.phone = phone;
            this.email = email;
            this.password = password;
        }

        public void Setname(string name)
        {
            this.Firstname = name;
        }
        public string getFirstname()
        {
            return this.Firstname;
        }
        public string getLastname()
        {
            return this.lastname;
        }
        public string getEmail()
        {
            return this.email;
        }
        public string getPhone()
        {
            return this.phone;
        }
    }

}