using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using DataAccessLayer.Models;

namespace DataAccessLayer.ViewModels
{
    public class ProductViewModelTest
    {
        public int id { get; set; }
        [Display(Name ="گروه بندی")]
        public int CategoryId { get; set; }

        [Display(Name = "نام محصول")]
        [MaxLength(200)]
        public string Name { get; set; }

        [Display(Name = "توضیح مختصر")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage ="قیمت را درست وارد کنید")]
        [Display(Name = "قیمت")]
        public double Price { get; set; }

        [Display(Name ="قیمت قبل تخفیف را وارد نمایید")]
        public decimal OldPrice { get; set; }

        [Display(Name = "موجود در انبار؟")]
        public bool IsExist { get; set; }

        [Display(Name ="ایا مایلید این محصول در قسمت محصولات ویژه نمایش داده شود")]
        public bool IsSpecial { get; set; }

        [Display(Name = "نمایش محصول در اسلایدر؟")]
        public bool ShowInSlider { get; set; }

        [Display(Name = "تاریخ ثبت محصول")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "تصویر محصول")]
        public IFormFile Picture { get; set; }

        //navigation
        [ForeignKey("CategoryId")]
        public Category category { get; set; }

    }
}
