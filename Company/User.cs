using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class User
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Surname { get; set; }
        public string Username { get; set; }
        public User( string name, string surname, string username)
        {
            Id = ++_id;
            Name = name;
            Surname = surname;
            Username = username;
        }

    }
}
