﻿using eCommerce.Models;
using eCommerce.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eCommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRepository homeRepository ;


        public HomeController(ILogger<HomeController> logger, IHomeRepository homeRepository)
        {
            _logger = logger;
            this.homeRepository = homeRepository;
        }

        public async Task<IActionResult> Index(string sTerm = "" , int categoryId = 0)
        {
            IEnumerable<Book> books = await homeRepository.displayBooks(sTerm , categoryId); 
            IEnumerable<Category> categories = await homeRepository.displayCat();
            BookDisplay bookmodel = new BookDisplay
            {
                Books = books,
                Categories = categories,
                Sterm = sTerm,
                categoryId = categoryId


            };
            return View(bookmodel);
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