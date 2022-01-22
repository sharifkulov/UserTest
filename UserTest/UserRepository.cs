using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserTest
{
    class UserRepository:IUserRepository<User>
    {
        private readonly List<User> UserList = new List<User>();


        public void AddUser(int Id, string Name, int Phone, int Age)
        {
            UserList.Add(new User(Id,Name,Phone,Age));                                 
        }
        public IEnumerable<User> GetUser(int Id)
        {
            User found = UserList.Find(item => item.Id == Id);

            Console.Write("Пользователь с Id {0} найден: ", Id);
            Console.WriteLine("ID :  {0}, имя пользователя:  {1}, Телефон :  {2}, Возраст :  {3} лет", found.Id, found.Name, found.Phone, found.Age);
            return UserList;
        }
        public IEnumerable<User> GetOrderedUsers()
        {
            UserList.Sort((x, y) => x.Id.CompareTo(y.Id));
            Console.WriteLine("Список пользователей ");
            
            for (int i = 0; i < UserList.Count; i++)
            {

                Console.WriteLine("ID :  {0}, имя пользователя:  {1}, Телефон :  {2}, Возраст :  {3} лет", UserList[i].Id, UserList[i].Name, UserList[i].Phone, UserList[i].Age);
            }
            return UserList;
        }
        public void DeleteUser(int Id)
        {
            Console.WriteLine("*Пользователь с Id {0} удален*", Id);
            UserList.RemoveAt(Id-1);
        }
        public void UpdateUser(int Id, string NewName, int NewPhone, int NewAge)
        {
            Console.WriteLine("*Пользователь с Id {0} обновлен*", Id);

            var user = UserList.FirstOrDefault(d => d.Id == Id);
            if (user != null)
            {
                user.Name = NewName;
                user.Phone = NewPhone;
                user.Age = NewAge;
            }
        }
    }
}
