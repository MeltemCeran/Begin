using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntities.Concrete
{
    public class Possibility : BaseEntity
    {
        public List<Move> Moves { get; set; } = new List<Move>();
        public List<Result> MyProperty { get; set; }
    }
}
