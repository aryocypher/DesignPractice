using CSharpDesignPatternsPractice.Creational.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UserBuilder ub= new UserBuilder();

//User user= ub.SetName("test").SetEmail("test@gmail.com").SetAddress("some address").Build();

namespace CSharpDesignPatternsPractice.Creational.Builder
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }

    public class UserBuilder
    {
        public User User { get; set; }


        public UserBuilder() { 
            User= new User();
        }

        public UserBuilder SetName(string name)
        {
            User.Name=name;
            return this;
        }

        public UserBuilder SetEmail(string email)
        {
            User.Email=email;
            return this;
        }

        public UserBuilder SetAddress(string address)
        {
            User.Address=address;
            return this;
        }

        public User Build()
        {
            return User;
        }

    }


}
