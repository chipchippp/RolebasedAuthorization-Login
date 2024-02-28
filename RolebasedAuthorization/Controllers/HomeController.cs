using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RolebasedAuthorization.Data;
using RolebasedAuthorization.Models;
using System.Diagnostics;

namespace RolebasedAuthorization.Controllers
{
    [Authorize(Roles = "admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
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
        [HttpPost]
        public List<object> GetToTalOrders()
        {
            List<object> data = new List<object>();
            List<string> labels = _context.Orders.Select(m => m.MonthName).ToList();
            List<int> total = _context.Orders.Select(t => t.TotalOrders).ToList();
            data.Add(labels);
            data.Add(total);
            return data;
        }
    }
}
