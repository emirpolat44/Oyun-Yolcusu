using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager
    {
        ICommentDAL _commentdal;

        public CommentManager(ICommentDAL commentdal)
        {
            _commentdal = commentdal;
        }

        public void CommentAdd(Comment comment)
        {
            _commentdal.Insert(comment);
        }

        public void Delete(Comment comment)
        {
            _commentdal.Delete(comment);
        }

        public Comment GetById(int id)
        {
            return _commentdal.Get(x => x.Com_id == id);
        }

        public Comment GetCommentsByNewId(int newId)
        {
            return _commentdal.Get(x => x.Com_news == newId);
        }

        public List<Comment> GetList()
        {
            return _commentdal.List();
        }

        public void Update(Comment comment)
        {
            _commentdal.Update(comment);
        }
    }
}
