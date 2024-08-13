using webApplication.createusers;
using webApplication.DbContext;
using FastEndpoints;
using webApplication.Models;

namespace webApplication.Services
{
    public class UserService(Data Datalist)
    {
       

        public UserModel createusers(UserModel candidate)
        {
            Datalist.Users.Add(candidate);
            return candidate;
        }
        public List<UserModel> GetUsers()
        {
            return Datalist.Users;
        }
        public void DeleteUser(int id)
        {
            int i = 0;
           while(i<=Datalist.Users.Count())
            {
                if (Datalist.Users[i].Id==id)
                { 
                Datalist.Users.RemoveAt(i);
                    return;
                
            }
                i++;
            
              
            }
        }

        internal UserModel UpdateUser(UserModel Toupdate)
        {
            int id = Toupdate.Id;
            Datalist.Users[id].Id = Toupdate.Id;
            Datalist.Users[id].Name = Toupdate.Name;
            Datalist.Users[id].Profession=Toupdate.Profession;
            return Datalist.Users[id];

        }
    }
}
