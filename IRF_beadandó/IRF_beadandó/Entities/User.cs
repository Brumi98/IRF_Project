using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_beadandó.Entities
{
    public class User
    {
        public int ID { get; set; }

        public string Felhasználó { get; set; }

        public string Jelszó { get; set; }

        public int JelöltekFK { get; set; }
    }
}
