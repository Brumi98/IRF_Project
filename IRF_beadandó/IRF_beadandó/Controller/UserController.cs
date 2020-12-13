using IRF_beadandó.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRF_beadandó.Entities;
using IRF_beadandó.Services;
using System.Text.RegularExpressions;

namespace IRF_beadandó.Controller
{
    public class UserController
    {
        public IUserManager UserManager { get; set; }

        public UserController()
        {

            UserManager = new UserManager();

        }

        public bool ValidateJelszo(string jelszo)
        {

            return Regex.IsMatch(jelszo, "(?=.[A-z])(?=.*[a-z])");



        }


    }
}
