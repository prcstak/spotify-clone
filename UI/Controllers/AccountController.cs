﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers;

public class AccountController : Controller
{
    
    public IActionResult Overview()
    {
        return View();
    }
}