using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleBuy.Models
{
    public class Login
    {
        public int Id { get; set; }

        public String username { get; set; }

        public String password { get; set; }

        public int typeaccess { get; set; }

        public char active { get; set; }
    }
}
