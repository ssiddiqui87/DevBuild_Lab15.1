﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab15_1.Models;
using System.Net.Http;

namespace Lab15_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            //1. Make the HttpClient
         //   var client = new HttpClient();
          //  client.BaseAddress = new Uri("https://deckofcardsapi.com");

            //2. Make the API call and put the result in a variable
           // var response = await client.GetAsync("api/deck/new/shuffle/?deck_count=1");

            //3. Parse the response contents as your typed object
            //in this case, it contains an array of JokeContent objects inside the Value
           // var deck = await response.Content.ReadAsAsync<DeckId>();

            return View();
        }



        public async Task<IActionResult> DrawCards()
        {
            //1. Make the HttpClient
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://deckofcardsapi.com");


            //2. Make the API call and put the result in a variable
            var response = await client.GetAsync("api/deck/new/draw/?count=5");

            //3. Parse the response contents as your typed object
            //in this case, it contains an array of JokeContent objects inside the Value
            Deck deck = await response.Content.ReadAsAsync<Deck>();

            return View(deck);
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
