﻿using Microsoft.AspNetCore.Mvc;

namespace Ecommers.Controllers
{
	public class BookController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
