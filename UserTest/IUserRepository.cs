using System;
using System.Collections.Generic;
using System.Text;

namespace UserTest
{
    interface IUserRepository<User> where User:class
    {
        IEnumerable<User> GetOrderedUsers();
        void AddUser(int Id, string Name, int Phone, int Age );
        IEnumerable<User> GetUser(int Id);
        void DeleteUser(int Id);
        void UpdateUser(int Id, string Name, int Phone, int Age);
    }
}
