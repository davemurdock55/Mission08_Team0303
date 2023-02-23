using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission08_Team0303.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission08_Team0303.Controllers
{
    public class HomeController : Controller
    {

        private TaskContext taskContext { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, TaskContext task_context)
        {
            _logger = logger;
            taskContext = task_context;
        }



        [HttpGet]
        public IActionResult Index()
        {
            // putting the movieinfo(response) of the moviesContext table context object into a list of type "Movie"
            var TaskList = taskContext.responses
                // getting the Cateogry object associated with that movie (through the CategoryID FK relationship)
                .Include(x => x.Category)
                //making sure the movie hasn't been edited
                //.Where(x => x.Edited != true)
                // ordering by Title
                .OrderBy(x => x.MovieID)
                .ToList();


            // putting that MovieList into the View function as "context" for the page
            return View(MovieList);
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
