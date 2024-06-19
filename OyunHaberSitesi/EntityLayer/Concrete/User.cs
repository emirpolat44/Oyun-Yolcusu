using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int User_id { get; set; }

        [Required]
        [StringLength(25)]
        public string User_name { get; set; }

        [Required]
        [StringLength(35)]
        public string User_password { get; set; }

        [Required]
        [StringLength(200)]
        public String User_mail { get; set; }

        [DefaultValue(0)]
        public Boolean User_writer { get; set; }

        public DateTime User_regdate { get; set; } = DateTime.Now;

        public ICollection<Comment> Comments { get; set; }
    }
}
