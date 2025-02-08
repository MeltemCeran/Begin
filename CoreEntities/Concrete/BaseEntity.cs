using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntities.Concrete
{
    public class BaseEntity
    {
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string? Music { get; set; }
        //if(var outcome == move ? null olmasa iyi olur : null olabilir muhtemelende null olur;)
        public int Id { get; set; }

    }
}