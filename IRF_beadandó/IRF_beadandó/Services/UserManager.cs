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
    class UserManager : AccountManager
    {
        public BindingList<User> Users { get; } = new BindingList<User>();

        //public User CreateAccount(User user)
        //{

        //}


    }
}
