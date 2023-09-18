using DataAccessLayer.Abstrac;
using DataAccessLayer.Concrete.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntitiyFramework
{
   public class EfContactDal: GenericRepository<Contact>, IContactDal
    {

    }
}
