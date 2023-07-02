using EasyCash.DtoLayer.Dtos.AppUserDtos;
using EasyCash.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCash.Web.Controllers;

public class RegisterController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public RegisterController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Index(AppUserRegisterDto registerDto)
    {
        if (ModelState.IsValid)
        {
            AppUser appUser = new()
            {
                UserName = registerDto.UserName,
                Name = registerDto.Name,
                Email = registerDto.Email,
                Surname = registerDto.Surname,
            };
            var result = await _userManager.CreateAsync(appUser, registerDto.Password);
            if (result.Succeeded)
                return RedirectToAction("Index", "ConfirmMail");
            result.Errors.ToList().ForEach(error => ModelState.AddModelError(string.Empty, error.Description));
        }
        return View();
    }
}
