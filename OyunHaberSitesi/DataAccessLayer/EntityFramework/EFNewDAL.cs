using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFNewDAL : GenericRepository<New>, INewDAL
    {
        public New List(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
