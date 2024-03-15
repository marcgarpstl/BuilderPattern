using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class User
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public User Run()
        {
            return CreateUser();
        }

        public string SetName()
        {
            Console.Write("Name: ");
            return Name = Console.ReadLine();
        }
        public string SetLastname()
        {
            Console.Write("Lastname: ");
            return Lastname = Console.ReadLine();
        }
        public int SetAge()
        {
            Console.Write("Age: ");
            return Age = int.Parse(Console.ReadLine());
        }

        public User CreateUser()
        {
            SetName();
            SetLastname();
            SetAge();

            var user = new UserBuilder()
                .SetName(Name)
                .SetLastname(Lastname)
                .SetAge(Age)
                .Build();

            return user;
        }
    }
}
