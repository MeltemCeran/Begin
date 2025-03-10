﻿using CoreEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntities.Concrete
{
    public class Move : IBaseEntity
    {
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Music { get; set ; }
        public string MusicUrl { get; set; }
        public int Id { get; set; }
        public DateTime MoveStart { get; set; } = DateTime.Now; //buna sonra bida bi bakayım.
        public NextMove NextMove { get; set; }
        public int NextMoveId { get; set; }
        public List<Possibility> Possibilities { get; set; }
        public ShortTermPlan? ShortTermPlan { get; set; }
        public int?  ShortTermPlanId { get; set; }
    }
}
