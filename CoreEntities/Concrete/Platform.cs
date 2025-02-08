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
        public List<Reactions> Reactions { get; set; } = new List<Reactions>();
    }

    public class Reactions
    {
        public int Views { get; set; } //görüntülenme
        public string Comment { get; set; } // aslında burda yorum değil geri dönüş şekli. 
        public string CommentType  { get; set; } //resim,yazı,video,görsel? bu enum olsun. 
        public int PlatformId { get; set; } //aslında platformda enum olsa olur.
    }
}
