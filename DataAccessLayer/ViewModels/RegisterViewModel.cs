using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا ایمیل خود را وارد نمایید")]
        [MaxLength(300)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا نام و نام خانوادگی خود را وارد نمایید")]
        [MaxLength(300)]
        public string FullName { get; set; }

        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "وارد کردن آدرس برای ساخت حساب کاربری الزامی است")]
        public string Address { get; set; }

        [Display(Name = "شماره همراه")]
        [Required(ErrorMessage = "وارد کردن شماره همراه برای ساخت حساب کاربری الزامی است")]
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string PhoneNumber { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا کلمه عبور خود را وارد نمایید")]
        [MaxLength(100)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا تکرار کلمه عبور خود را وارد نمایید")]
        [MaxLength(100)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Repassword { get; set; }

      

    }
}
