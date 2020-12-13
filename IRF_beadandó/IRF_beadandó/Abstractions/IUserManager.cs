using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRF_beadandó.Entities;

namespace IRF_beadandó.Abstractions
{
    public interface IUserManager
    {
        DatabaseEntities_1 context { get; }

        User CreateUser(User user);
    }
}
