using napelem_telepito_kozpont.Backend.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelem_telepito_kozpont.Backend.Controllers
{
    public class DataGenerator
    {
        public void CreateUsers()
        {
            using (var context = new NapelemDbContext())
            {
                if (!context.Users.Any())
                {
                    var users = new List<User>
                    {
                        // 1= Szerelő, 2=Raktáros 3=Raktárvezető, 0 = ADMIN
                        new User {Name = "Napelem szerelő", Password = null, Role = 1},
                        new User {Name = "Raktáros Teri", Password = null, Role = 2},
                        new User {Name = "Pista bá", Password = null, Role = 3},
                        new User {Name = "Szervízes Ferenc", Password = null, Role = 1},
                        new User {Name = "Raktár Vezető Richárd", Password = null, Role = 3},
                        new User {Name = "ADMIN BOSS", Password = null, Role = 0}
                    };

                    context.Users.AddRange(users);
                    context.SaveChanges();
                }
            }
        }

    }
}
