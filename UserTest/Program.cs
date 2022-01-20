using System;

namespace UserTest
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository user1 = new UserRepository();
            user1.AddUser(1, "Diana", 3482374, 19);
            user1.AddUser(3, "Anton", 11000201, 21);
            user1.AddUser(4, "Mirana", 11221111, 25);
            user1.AddUser(2, "Dima", 212121, 40);
            user1.GetOrderedUsers();
            user1.UpdateUser(2, "DimaNew", 999000009, 17);
            user1.GetOrderedUsers();
            user1.DeleteUser(1);
            user1.GetOrderedUsers();
            user1.GetUser(2);
            
        }
    }
}
