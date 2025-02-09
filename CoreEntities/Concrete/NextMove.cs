using CoreEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntities.Concrete
{
    public class NextMove : IBaseEntity
    {
        public DateOnly Date { get; set ; }
        public TimeOnly Time { get; set; }
        public string Music { get; set; }
        public int Id { get; set; }
        public DateTime NextMoveStart { get; set; } = DateTime.Now;
        public string? Description { get; set; }
        public Move Move { get; set; }
        public int MoveId { get; set; }
    }
}
