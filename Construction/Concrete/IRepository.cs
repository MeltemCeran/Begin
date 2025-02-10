using CoreEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.Concrete
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        List<T> GetAllAtThatTime(DateTime thatDay);

        //sorgunun tetiklendiği günü kaydeden bir metot. ya da o günü alan metot? Buna Trigger eklemek mi lazım o zaman?
        //dbye her sorgu atılan tarihi tutmak. bu kesin programların içinde vardır bu özellik. onu hallederiz. 

        /// <summary>
        ///sayfadaki müzik isminin youtube ya da spotify linkine gitmek için tıklama metodu.
        /// </summary>
        /// <param name="link"></param>
        /// <param name="thatDay"></param>
        void GotToTheMusicLink(string link, DateTime thatDay);


    }
}
