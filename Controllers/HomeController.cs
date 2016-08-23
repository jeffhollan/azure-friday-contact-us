using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using azure_friday.Models;
using System.Net.Http;
using System.Text;
using System.Diagnostics;
using Newtonsoft.Json;

namespace azure_friday.Controllers
{
    
    public class HomeController : Controller
    {
        private const string form_url = @"http://requestb.in/151srvw1";

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Submitted()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            var form = new Models.ContactViewModel();
            return View(form);
        }

        public IActionResult Error()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> SubmitForm(ContactViewModel form)
        {
            using(var client = new HttpClient()){
                await client.PostAsync(form_url, 
                  new StringContent(JsonConvert.SerializeObject(form), Encoding.UTF8, "application/json"));
            }
            return View("Submitted");
        }
    }
}
