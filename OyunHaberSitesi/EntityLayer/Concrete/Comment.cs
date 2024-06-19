using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int Com_id { get; set; }

        [ForeignKey("Users")]
        public int Com_uid { get; set; }

        [ForeignKey("News")]
        public int Com_news { get; set; }

        [Required]
        [StringLength(600)]
        public String Com_text { get; set; }

        [DefaultValue(0)]
        public int Com_approval { get; set; }
        public DateTime Com_date { get; set; } = DateTime.Now;

        public User Users { get; set; }
        public New News { get; set; }
    }
}
