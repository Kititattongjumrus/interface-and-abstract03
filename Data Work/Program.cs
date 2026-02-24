using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptForUser
{
    internal class Program
    {
        private static List<User> CourseMember = new List<User>();

        static void Main(string[] args)
        {
            Console.WriteLine("Register to OOP course");

            bool adding = true;
            while (adding)
            {
                Console.WriteLine("Who are you: [Teacher, Student, Guest]:");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid input. Please enter Teacher, Student, or Guest.");
                    continue;
                }

                User newUser = null;

                if (input.Equals("teacher", StringComparison.OrdinalIgnoreCase))
                {
                    var newTeacher = new Teacher();
                    PromptForUserDetails(newTeacher);
                    newUser = newTeacher;
                }
                else if (input.Equals("student", StringComparison.OrdinalIgnoreCase))
                {
                    var newStudent = new Student();
                    PromptForUserDetails(newStudent);
                    newUser = newStudent;
                }
                else if (input.Equals("guest", StringComparison.OrdinalIgnoreCase))
                {
                    var newGuest = new Guest();
                    PromptForUserDetails(newGuest);
                    newUser = newGuest;
                }
                else
                {
                    Console.WriteLine("Unknown role. Please enter Teacher, Student, or Guest.");
                    continue;
                }

                CourseMember.Add(newUser);
                Console.WriteLine("User added.");

                Console.WriteLine("Do you want to add another user? [yes/no]:");
                string again = Console.ReadLine();
                if (!again.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    adding = false;
                }
            }

            Console.WriteLine();
            Console.WriteLine("This is all registered members of this OOP course:");
            for (int i = 0; i < CourseMember.Count; i++)
            {
                var member = CourseMember[i];
                Console.WriteLine("{0}. {1} - {2}", i + 1, member.GetType().Name, member.getFirstname());
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void PromptForUserDetails(User user)
        {
            Console.Write("First name: ");
            string name = Console.ReadLine() ?? string.Empty;

            Console.Write("Last name: ");
            string lastname = Console.ReadLine() ?? string.Empty;

            Console.Write("Phone: ");
            string phone = Console.ReadLine() ?? string.Empty;

            Console.Write("Email: ");
            string email = Console.ReadLine() ?? string.Empty;

            Console.Write("Password: ");
            string password = Console.ReadLine() ?? string.Empty;

            user.register(name, lastname, phone, email, password);
        }
    }
}