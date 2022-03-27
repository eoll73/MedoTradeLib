using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedoTradeLib.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public string Book { get; set; }
        public DateTime Data { get; set; }
    }
}
