using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class New
    {
        [Key]
        public int News_id { get; set; }

        [Required]
        [StringLength(70)]
        public String News_writer { get; set; }

        [ForeignKey("Categories")]
        public int News_category { get; set; }
        public Category Categories { get; set; }

        [Required]
        [StringLength(250)]
        public String News_topic { get; set; }

        [Required]
        [StringLength(2000)]
        public String News_summary { get; set; }

        [Required]
        [StringLength(6000)]
        public String News_content { get; set; }

        [Required]
        [StringLength(150)]
        public String News_source { get; set; }

        [Required]
        [StringLength(800)]
        public String News_image { get; set; }
        public DateTime News_date { get; set; } = DateTime.Now;

        public ICollection<Comment> Comments { get; set; }
    }
}
