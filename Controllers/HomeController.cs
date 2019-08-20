using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccount.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BankAccount.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context){
            dbContext = context;
        }
        public IActionResult Index()
        {
            return Redirect("register");
        }
        [HttpGet("register")]
        public IActionResult RegisterPage()
        {
            return View("Register");
        }
        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid){
                if(dbContext.Users.FirstOrDefault(u => u.Email == newUser.Email)!=null){
                    //email already registered
                    ModelState.AddModelError("Email","Email is already registered!");
                    return View("Register");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
                var newest = dbContext.Users.Last();
                newest.CreatedAt = DateTime.Now;
                newest.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("user_id",dbContext.Users.Last().user_id);
                return RedirectToAction("Success");
                
            }else{
                return View("Register");
            }
        }

        [HttpGet("login")]
        public IActionResult LoginPage(){
            return View("Login");
        }
        [HttpPost("login")]
        public IActionResult Login(LogUser user){
            var matchuser = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);
            if(matchuser == null){
                ModelState.AddModelError("Email","Invalid Email/Password");
                return View("Login");
            }else{
                var hasher = new PasswordHasher<LogUser>();
                var result = hasher.VerifyHashedPassword(user, matchuser.Password, user.Password);
                if(result == 0){
                    ModelState.AddModelError("Email","Invalid Email/Password");
                    return View("Login");
                }
                HttpContext.Session.SetInt32("user_id",dbContext.Users.Last().user_id);
                return RedirectToAction("Success");
            }
        }
        public IActionResult Success(){
            int ? user_id = HttpContext.Session.GetInt32("user_id");
            if(user_id == null){
                return Redirect("/register");
            }else{
                var currUser = dbContext.Users.Include( u => u.UserTransactions).First(u => u.user_id == user_id);
                currUser.UserTransactions.OrderByDescending(t => t.createdAt);
                return View("Info",currUser);
            }
        }
        public IActionResult newTransaction(Transaction newtrans){
            if(!ModelState.IsValid){
                return RedirectToAction("Success");
            }else{
                if(newtrans.amount ==0){
                    return RedirectToAction("Success");
                }
                var currentUser = dbContext.Users.FirstOrDefault(u => u.user_id == HttpContext.Session.GetInt32("user_id"));
                if(newtrans.amount > 0){
                    //Deposit
                    currentUser.balance+=newtrans.amount;
                    newtrans.createdAt = DateTime.Now;
                    dbContext.Transactions.Add(newtrans);
                    dbContext.SaveChanges();
                    currentUser.UserTransactions.Add(dbContext.Transactions.Last());
                }else if(newtrans.amount < 0){
                    if(currentUser.balance < (newtrans.amount*-1)){
                        //not enough funds in balance to withdraw
                        return RedirectToAction("Success");
                    }else{
                        //Withdraw
                        currentUser.balance+=newtrans.amount;
                        newtrans.createdAt = DateTime.Now;
                        dbContext.Transactions.Add(newtrans);
                        dbContext.SaveChanges();
                        currentUser.UserTransactions.Add(dbContext.Transactions.Last());

                    }
                }
                return RedirectToAction("Success");
            }
        }
        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return Redirect("/register");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
