using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDAL _userdal;

        public UserManager(IUserDAL userdal)
        {
            _userdal = userdal;
        }

        public void NewAdd(User user)
        {
            _userdal.Insert(user);
        }

        public List<User> GetList()
        {
            return _userdal.List();
        }

        public List<User> List()
        {
            return _userdal.List();
        }

        public User GetById(int id)
        {
            return _userdal.Get(x => x.User_id == id);
        }

        public void Delete(User user)
        {
            _userdal.Delete(user);
        }
        public void Update(User user)
        {
            _userdal.Update(user);
        }
    }
}
