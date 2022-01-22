using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.ViewModels;
using DataAccessLayer.Repository;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace MyElectricShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserRepository _userrepository;
        public AccountController(IUserRepository userRepository)
        {
            _userrepository = userRepository;
        }

        #region Register
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            if (_userrepository.IsExistUserByEmail(register.Email))
            {
                ModelState.AddModelError("Email", "این ایمیل قبلا استفاده شده است");
                return View(register);
            }
            DataAccessLayer.Models.User user = new DataAccessLayer.Models.User() { Email = register.Email,Fulllname=register.FullName ,Password = register.Password,RegisterDate=DateTime.Now, Address=register.Address,PhoneNumber=register.PhoneNumber };
            _userrepository.CreateUser(user);
            _userrepository.save();
            return View("SuccessfullRegister", register);
        }
        #endregion

        #region Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            if(!ModelState.IsValid)
            {
                return View(login);
            }
            var client = _userrepository.GetUserForLogin(login.Email, login.Password);
            if (client==null)
            {
                ModelState.AddModelError("Email", "کاربری یافت نشد");
                return View(login);
            }
            var claims = new List<Claim>
            {
                //اینج
                new Claim(ClaimTypes.NameIdentifier,client.UserId.ToString()),
                new Claim(ClaimTypes.Email,client.Email),
                new Claim(ClaimTypes.Role,client.IsAdmin.ToString())
            };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            var properties = new AuthenticationProperties { IsPersistent = login.Rememberme };
            HttpContext.SignInAsync(principal, properties);
            return Redirect("/");


        }
        #endregion

        #region LogOut
        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Account/Login");
        }
        #endregion


        public IActionResult editprofile()
        {
            int userid = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString());
            var user = _userrepository.GetUserByUserId(userid);
            return View(user);
        }

        [HttpPost]
        public IActionResult editprofile([Bind("UserId,Email,Fulllname,Address,PhoneNumber,Password")] User user)
        {
            var currentuser = _userrepository.GetUserByUserId(user.UserId);
            currentuser.Email = user.Email;
            currentuser.Fulllname = user.Fulllname;
            currentuser.Address = user.Address;
            currentuser.PhoneNumber = user.PhoneNumber;
            currentuser.Password = user.Password;
            
            _userrepository.save();
            return RedirectToAction("successfullyProfileEdited");
        }
        
        public IActionResult successfullyProfileEdited()
        {
            int userid = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString());
            var user = _userrepository.GetUserByUserId(userid);
            ViewBag.name = user.Fulllname;
            LogOut();
            return View();
        }

    }
}

















//if (!ModelState.IsValid)
//{
//    return View(login);
//}
//var client = _userrepository.GetUserForLogin(login.Email, login.Password);
//if (client == null)
//{
//    ModelState.AddModelError("Email", "کاریری یافت نشد");
//    return View(login);
//}

//var claims = new List<Claim>()
//{
//     new Claim(ClaimTypes.NameIdentifier,client.UserId.ToString()),
//     new Claim(ClaimTypes.Email, client.Email)
//};
//var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
//var principal = new ClaimsPrincipal(identity);
//var properties = new AuthenticationProperties { IsPersistent = login.Rememberme };
//HttpContext.SignInAsync(principal, properties);
//return Redirect("/");