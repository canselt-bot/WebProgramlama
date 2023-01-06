using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IAboutService
    {
        void AboutAdd(About about);
        void AboutRemove(About about);
        void AboutUpdate(About about);
        List<About> GetAllAbouts();
        About GetById(int id);
    }
}
