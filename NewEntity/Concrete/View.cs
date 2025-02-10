using NewEntity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEntity.Concrete
{
    public class View
    {
        public int Id { get; set; }
        public DateTime PublishDay { get; set; }
        public string PlatformName { get; set; }
        //public string ConceptName { get; set; }
        public int ConceptId { get; set; }
        public Concept Concept { get; set; }
        public int HowManyView { get; set; }
        public DateTime CheckDate { get; set; } //bu belirli aralıklarla toplam veri çekilen tarihleri tutacak. Bunun için bi standart belirleriz. 4 günde bir olsun istiyorum.
        public State State { get; set; }


        List<View> views = new List<View>
{
    new View { Id = 1, PublishDay = new DateTime(2025, 2, 8), PlatformName = "Instagram", ConceptId = 1, HowManyView = 1284, CheckDate = new DateTime(2025, 2, 10), State = State.Positive },
    new View { Id = 2, PublishDay = new DateTime(2025, 2, 9), PlatformName = "Instagram", ConceptId = 2, HowManyView = 1000, CheckDate = new DateTime(2025, 2, 10), State = State.Positive },
    new View { Id = 3, PublishDay = new DateTime(2025, 2, 10), PlatformName = "Instagram", ConceptId = 2, HowManyView = 350, CheckDate = new DateTime(2025, 2, 10), State = State.Positive },
    new View { Id = 4, PublishDay = new DateTime(2025, 2, 10), PlatformName = "Instagram", ConceptId = 2, HowManyView = 137, CheckDate = new DateTime(2025, 2, 10), State = State.Positive },
    new View { Id = 5, PublishDay = new DateTime(2025, 2, 8), PlatformName = "Linkedin", ConceptId = 3, HowManyView = 533, CheckDate = new DateTime(2025, 2, 10), State = State.Positive },
    new View { Id = 6, PublishDay = new DateTime(2025, 2, 9), PlatformName = "Linkedin", ConceptId = 3, HowManyView = 768, CheckDate = new DateTime(2025, 2, 10), State = State.Positive },
    new View { Id = 7, PublishDay = new DateTime(2025, 2, 9), PlatformName = "Linkedin", ConceptId = 3, HowManyView = 2152, CheckDate = new DateTime(2025, 2, 10), State = State.Positive },
    new View { Id = 8, PublishDay = new DateTime(2025, 2, 10), PlatformName = "Linkedin", ConceptId = 3, HowManyView = 507, CheckDate = new DateTime(2025, 2, 10), State = State.Positive },
    new View { Id = 9, PublishDay = new DateTime(2025, 2, 10), PlatformName = "Linkedin", ConceptId = 3, HowManyView = 69, CheckDate = new DateTime(2025, 2, 10), State = State.Positive },
    new View { Id = 10, PublishDay = new DateTime(2025, 2, 1), PlatformName = "Linkedin", ConceptId = 4, HowManyView = 202, CheckDate = new DateTime(2025, 2, 10), State = State.Positive },
    new View { Id = 11, PublishDay = new DateTime(2025, 2, 1), PlatformName = "Github", ConceptId = 4, HowManyView = 394, CheckDate = new DateTime(2025, 2, 10), State = State.Positive },
    new View { Id = 12, PublishDay = new DateTime(2025, 2, 6), PlatformName = "Mail", ConceptId = 5, HowManyView = 1, CheckDate = new DateTime(2025, 2, 6), State = State.Positive },
    new View { Id = 13, PublishDay = new DateTime(2025, 2, 10), PlatformName = "Mail", ConceptId = 5, HowManyView = 1, CheckDate = new DateTime(2025, 2, 10), State = State.Positive }
};



    }
}
