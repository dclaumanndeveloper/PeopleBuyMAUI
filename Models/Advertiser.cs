using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleBuy.Models
{
    public class Advertiser
    {
        public int Id { get; set; }

        public String razaosocial { get; set; }

        public String CNPJ { get; set; }

        public String phone { get; set; }

        public String login { get; set; }
        public char active { get; set; }
    }
}
