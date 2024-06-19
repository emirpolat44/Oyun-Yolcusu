using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetList();
        void CommentAdd(Comment comment);
        Comment GetById(int id);
        Comment GetCommentsByNewId(int newId);
        void Delete(Comment comment);
        void Update(Comment comment);
    }
}
