using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket
{
    internal class User
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string FathersName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public string Sex { get; set; }

        public User(string surname, string name, string fathersName, string country, string city, string phone, DateTime birthday, string sex)
        {
            Surname = surname;
            Name = name;
            FathersName = fathersName;
            Country = country;
            City = city;
            Phone = phone;
            Birthday = birthday;
            Sex = sex;
        }
    }
}
