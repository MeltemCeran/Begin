using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEntity.Concrete
{
    public class BaseLife
    {
        public int Id { get; set; }
        public string Season { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Music { get; set; }
    }
}
