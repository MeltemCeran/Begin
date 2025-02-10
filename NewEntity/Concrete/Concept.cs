using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEntity.Concrete
{
    public class Concept
    {
        public int Id { get; set; }
        public string Name { get; set; }

        List<Concept> Concepts = new List<Concept>
        {
            new Concept { Id = 1, Name = "Reel Video" },
            new Concept { Id = 2, Name = "Story" },
            new Concept { Id = 3, Name = "Gönderi" },
            new Concept { Id = 4, Name = "Profil Ziyareti" },
            new Concept { Id = 5, Name = "Deneme" }
        };

    }
}
