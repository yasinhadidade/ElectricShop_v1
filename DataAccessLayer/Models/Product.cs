using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace DataAccessLayer.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        [Display(Name = "نام محصول")]
        [MaxLength(200)]
        public string Name { get; set; }

        [Display(Name ="توضیح مختصر")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "قیمت")]
        [MaxLength(200)]
        public double Price { get; set; }

        [Display(Name ="قیمت قبل تخفیف")]
        public decimal OldPrice { get; set; }

        [Display(Name = "موجود در انبار؟")]
        public bool IsExist { get; set; }

        [Display(Name ="ایا جرء محصولات ویژه محسوب میشود؟")]
        public bool IsSpecial { get; set; }

        [Display(Name = "نمایش محصول در اسلایدر؟")]
        public bool ShowInSlider { get; set; }

        [Display(Name = "تاریخ ثبت محصول")]
        public DateTime CreateDate { get; set; }

        [Display(Name ="تعداد کل فروش محصول")]
        public int TotalNumberOfSales { get; set; }

        //[Display(Name = "تصویر محصول")]
        //public IFormFile Picture { get; set; }

        //navigation
        [ForeignKey("CategoryId")]
        public Category category { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
        public List<Comment> Comment { get; set; }





    }
}
