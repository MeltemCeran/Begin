using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntities.Concrete
{
    public class Results : BaseEntity
    {
        public string MoveResponse { get; set; }
        public DateTime ResponseTime { get; set; } // cevaplanma süresi.
    }
}
