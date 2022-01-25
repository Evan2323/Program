using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program.Models
{
    public class Money
    {
        public int Id { get; set; }
        public double Sum { get; set; }
        public string  Operetion { get; set; }
        public DateTime? DateTime { get; set; }

        public  User User { get; set; }
    }
}
