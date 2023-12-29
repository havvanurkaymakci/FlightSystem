using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightSystem.Data;
using FlightSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace FlightSystem.Controllers
{
    public class HomeController : Controller

    {
        //ApplicationDbContext _context = new ApplicationDbContext();


        //public HomeController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;
       
        public HomeController(IConfiguration _configuration, ILogger<HomeController> logger)
        {
            _logger = logger;
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionBuilder.UseSqlServer(_configuration.GetConnectionString("FlightSystem"));
            _context=new ApplicationDbContext(optionBuilder.Options);   
        }
       
        public IActionResult Index()
        {
            return View();
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

        [HttpGet]
        public IActionResult UcusSorgusu(string Departure,string Destination, DateTime? departuredate)
        {

            var sonuc1 = _context.Flights
                .Where(x => x.FlightDeparture.Contains(Departure) &&
                x.FlightDestination.Contains(Destination) &&
                   (departuredate == null || DateTime.Compare(x.FlightDepartureDate.Date, departuredate.Value.Date) == 0))
               .ToList();

            return View("Sonuc",sonuc1);
        }

       
    }
}
