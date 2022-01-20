using System;
using System.Collections.Generic;
using System.Text;

namespace UserTest
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
        public User(int Id, string Name, int Phone, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Phone = Phone;
            this.Age = Age;
        }
    }
}
