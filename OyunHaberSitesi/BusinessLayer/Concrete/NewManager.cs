using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewManager : INewService
    {
        INewDAL _newdal;

        public NewManager(INewDAL newdal)
        {
            _newdal = newdal;
        }

        public void NewAdd(New @new)
        {
            _newdal.Insert(@new);
        }

        public List<New> GetList()
        {
            return _newdal.List();
        }

        public List<New> List()
        {
            return _newdal.List();
        }

        public New GetById(int id)
        {
            return _newdal.Get(x => x.News_id == id);
        }

        public List<New> GetNewListWithCategory()
        {
            throw new NotImplementedException();
        }
        public void Delete(New @new)
        {
            _newdal.Delete(@new);
        }
        public void Update(New news)
        {
            _newdal.Update(news);
        }
    }
}
