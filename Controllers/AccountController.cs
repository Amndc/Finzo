using Finzo.Models;
using Finzo.Repository;
using Finzo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Finzo.Controllers
{
   
    public class AccountController : Controller
    {
        private readonly UserService _userService;

        

        public AccountController(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult Login()
        {
            return View(new Users());  // Renderiza a página de login
        }

        [HttpPost]
        public IActionResult Register(Users user)
        {
            //if (ModelState.IsValid)
            //{
            //    _userService.addUser(user);
            //    return RedirectToAction("Index", "Home");
            //}

            return View(user);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Users user)
        {

            if (ModelState.IsValid)
            {
                var result = await _userService.validateLogin(user);
                
                if (!result.Success)
                {
                   

                }
                else
                {
                    return RedirectToAction("Index", "Home");

                }

            }



            return View();

        }

    }
}
