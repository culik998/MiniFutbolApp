using MiniFutbolApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFutbolApp.Infrastucture
{
 public  static class UserExtension
    {
        public static User GetUser(this DbSet<User> Users, LoginModel loginModel)
        {
            return Users.Where(x => x.Name == loginModel.Name &&
                               x.Password == loginModel.Password



            ).FirstOrDefault();

        }
    }
}
