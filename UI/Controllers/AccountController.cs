using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers;

public class AccountController : Controller
{
    
    public IActionResult Overview()
    {
        return View();
    }

    public IActionResult Plans()
    {
        return View();
    }
    
    public IActionResult LogIn()
    {
        return View();
    }

    public IActionResult SignUp()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult ChangePassword() => View();
}