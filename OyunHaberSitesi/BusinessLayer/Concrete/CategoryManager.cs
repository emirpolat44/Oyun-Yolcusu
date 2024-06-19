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
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categorydal;

        public CategoryManager(ICategoryDAL categorydal)
        {
            _categorydal = categorydal;
        }

        public void CategoryAdd(Category category)
        {
            _categorydal.Insert(category);
        }

        public void Delete(Category category)
        {
            _categorydal.Delete(category);
        }

        public Category GetById(int id)
        {
            return _categorydal.Get(x => x.Category_id == id);
        }

        public List<Category> GetList()
        {
            return _categorydal.List();
        }

        public void Update(Category category)
        {
            _categorydal.Update(category);
        }


    }
}
