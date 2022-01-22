using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
   public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(300)]
        [Display(Name ="ایمیل")]
        public string Email { get; set; }

        [Required]
        [MaxLength(300)]
        [Display(Name = "نام و نام خانوادگی")]
        public string Fulllname { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "رمز عبور")]

        public string Password { get; set; }
        [Display(Name = "تاریخ ثبت نام")]
        public DateTime RegisterDate { get; set; }
        [Display(Name = "آدرس")]
        public string Address { get; set; }
        [Display(Name = "شماره همراه")]
        public string PhoneNumber { get; set; }
        [Display(Name = "آیا ادمین میباشد؟")]
        public bool IsAdmin { get; set; }

        //navigation property
        public Order order { get; set; }


    }
}
