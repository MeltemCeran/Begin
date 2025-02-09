using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntities.Concrete
{
    public class Platform : BaseEntity
    {
        public string PlatformName { get; set; }
        //public Reactions Reaction { get; set; } = new ICollection<Reactions>(); !!! buna bakalım sonra 
        public List<Reaction> Reactions { get; set; } = new List<Reaction>();
    }
}
