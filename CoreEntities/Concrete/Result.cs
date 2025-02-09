using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntities.Concrete
{
    public class Result : BaseEntity
    {
        public string MoveResponse { get; set; }
        public DateTime ResponseTime { get; set; } // cevaplanma süresi.
        public List<Possibility> Possibilities { get; set; }
    }
}
