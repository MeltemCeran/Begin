using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntities.Concrete
{
    public class ShortTermPlan : BaseEntity
    {
        public string Topic { get; set; }
        public Platform Platform { get; set; }
        public string? How {  get; set; }
        public bool IsNeedMoney { get; set; }
        public decimal Cost { get; set; }
        public bool NeedMove { get; set; } // if NeedMove is true : Move.Add(new move)
        public Move? Move { get; set; }
        public int MoveId { get; set; }


        /// <summary>
        /// bu metoda bu isim bulmak gerek. belki gerek bile yoktur buna bakarız sonra.
        /// </summary>
        public void Metot()
        {
            ShortTermPlan x = new ShortTermPlan();

            if (x.IsNeedMoney == false)
            {
                Cost = 0; 
            }
        }
    }

}
