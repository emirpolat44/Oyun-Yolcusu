using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int Category_id { get; set; }

        [Required]
        [StringLength(50)]
        public String Category_name { get; set; }

        [Required]
        [StringLength(255)]
        public String Category_desc { get; set; }

        public ICollection<New> News { get; set; }
    }
}