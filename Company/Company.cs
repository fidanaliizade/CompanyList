using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Company
    {
        public int Id { get; set; }
        public  string Name { get; set; }

        List<User> Users = new List<User>();

        public void GetUser(int id)
        {
            try
            {
                User newUser = null;
                foreach (User user in Users)
                {
                    if (user.Id == id)
                    {
                        Console.WriteLine($"User name: {user.Name}  surname: {user.Surname}  username : {user.Username}");
                    }
                    else
                    {
                        throw new DataNotFoundException();
                    }
                }    
            }
            catch (DataNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void GetAllUsers()
        {
            foreach(User user in Users)
                Console.WriteLine(user);
        }

        public void DeleteUser(int id)
        {
            try
            {
                User newUser = null;
                foreach (User user in Users)
                {
                    if (user.Id == id)
                    {
                        newUser = user;
                        break;
                    }
                    
                }
                if(newUser != null)
                {
                    Users.Remove(newUser);
                }
                else
                {
                    throw new DataNotFoundException();
                }
            }
            catch(DataNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        public void UpdateUser(User user)
        {
            try
            {
                User NewUser = null;
                for(int i =0; i < Users.Count; i++)
                {
                    if (Users[i].Id == user.Id)
                        NewUser= Users[i];
                    break;
                }
                if ( NewUser != null)
                   {
                    NewUser.Name = user.Name;
                    NewUser.Surname = user.Surname;
                    NewUser.Username = user.Username;
                    NewUser.Id = user.Id;
                }
                else
                {
                    throw new  DataNotFoundException();
                }
            }
            catch (DataNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
