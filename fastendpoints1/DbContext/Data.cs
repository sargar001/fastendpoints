using webApplication.Models;
using webApplication.createusers;
using System.Xml.Linq;
namespace webApplication.DbContext
{
    public class Data
    {
        public List<UserModel> Users = new List<UserModel>
        {
           new UserModel { Id = 1, Name = "John Doe", Profession = "Software Engineer" },
           new UserModel { Id = 2, Name = "Jane Doe", Profession = "Doctor" },
           new UserModel { Id = 3, Name = "Bob Smith", Profession = "Lawyer" }
        };
        
    }
}
