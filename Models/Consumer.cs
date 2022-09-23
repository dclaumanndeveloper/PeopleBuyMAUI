using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleBuy.Models
{
    public class Consumer
    {
        public int Id { get; set; }

        public String name { get; set; }

        public String CPF { get; set; }

        public String phone { get; set; }

        public int LoginId { get; set; }

        public char active { get; set; }
    }
}
