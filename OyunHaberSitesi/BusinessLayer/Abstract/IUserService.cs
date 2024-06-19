using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        List<User> GetList();
        void NewAdd(User user);

        List<User> List();
        User GetById(int id);
        void Delete(User user);
        void Update(User user);
    }
}
