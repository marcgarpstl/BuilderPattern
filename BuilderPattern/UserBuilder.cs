using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class UserBuilder
    {
        private User _user = new User();

        public UserBuilder SetName(string name)
        {
            _user.Name = name;
            return this;
        }
        public UserBuilder SetLastname(string lastname)
        {
            _user.Lastname = lastname;
            return this;
        }
        public UserBuilder SetAge(int age)
        {
            _user.Age = age;
            return this;
        }
        public User Build()
        {
            return _user;
        }
    }
}
