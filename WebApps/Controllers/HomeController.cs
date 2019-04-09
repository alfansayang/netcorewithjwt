using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApps.Models;
using WebApps.Repository;

namespace WebApps.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        //do depedency injection by constructor injection
        public HomeController(IEmployeeRepository employeeRepository)
        {
            //without depedencyinjection
            //extremly to maintain, because imagine if we have many controller, how much we must maintain thats all controller if we use instance object
            //_employeeRepository = new EmployeeRepository();
            
            //use depedency injection
            //related with singleton pattern
            this._employeeRepository = employeeRepository;
            
        }

        public List<UserModel> GetEmployee()
        {
            return _employeeRepository.GerUsers();
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
    }
}
