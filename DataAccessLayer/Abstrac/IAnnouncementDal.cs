using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstrac
{
  public  interface IAnnouncementDal: IGenericDal<Announcement>
    {

        void AnnouncementStatusToTrue(int id);

        void AnnouncementStatusToFalse(int id);


    }
}
