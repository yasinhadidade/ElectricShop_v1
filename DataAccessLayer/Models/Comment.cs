using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
   public class Comment
    {
        [Key]
        public int Commentid { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string CommentText { get; set; }
        public int Productid { get; set; }

        //navigation property

      

        [ForeignKey("Productid")]
        public Product product { get; set; }

    }
}
