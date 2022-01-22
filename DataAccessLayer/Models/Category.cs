using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Display(Name = "عنوان گروه بندی")]
        [MaxLength(300)]
        public string CategoryName { get; set; }

        //navigation property
        public List<Product> products { get; set; }
    }
}
