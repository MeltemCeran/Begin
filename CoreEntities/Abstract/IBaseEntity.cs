using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntities.Abstract
{
    public interface IBaseEntity
    {
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Music { get; set; }
        public int Id { get; set; }

        ///IBaseEntityden kalıtım alan müzik eklemeli null olmasın. => moves
        ///BaseEntityden kalıtım alan müzik eklemesiz olabilir null olabilir => results
        ///olur böyle sanırım ya. 
    }
}
