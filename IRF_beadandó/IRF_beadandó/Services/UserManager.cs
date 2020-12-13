using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRF_beadandó.Abstractions;
using IRF_beadandó.Entities;


namespace IRF_beadandó.Services
{
    public class UserManager : IUserManager
    {
        public DatabaseEntities_1 context { get; } = new DatabaseEntities_1();

        public User CreateUser(User user)
        {
            var olduser = (from x in context.Users
                           where x.Jelszó.Equals(user.Jelszó)
                           select x).FirstOrDefault();

            if (olduser != null)
            {
                throw new ApplicationException("Már létezik felhasználó ilyen jelszóval");

            }

            context.Users.Add(user);

            return user;
        }

    }
}
