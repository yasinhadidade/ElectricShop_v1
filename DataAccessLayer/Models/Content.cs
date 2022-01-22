using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Content
    {
        [Key]
        public int Contentid { get; set; }
        [Display(Name ="عنوان مطلب")]
        public string Title { get; set; }

        [Display(Name ="نویسنده")]
        public string Author { get; set; }
        [Display(Name = "توضیح مختصر مطلب")]
        public string ShortDescription { get; set; }
        [Display(Name = "متن")]
        [DataType(DataType.MultilineText)]
        
        public string Text { get; set; }

        [Display(Name = "تعداد بازدید")]
        public int visit { get; set; }

        [Display(Name = "تاریخ تولید محتوا")]
        public DateTime CreateDate { get; set; }

        [Display(Name ="کلمات کلیدی")]
        public string Tags { get; set; }



        //navigation property
      

    }
}
