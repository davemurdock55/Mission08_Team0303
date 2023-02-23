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

        private TaskContext tasksContext { get; set; }

        public HomeController(TaskContext tasks_context)
        {
            tasksContext = tasks_context;
        }



        [HttpGet]
        public IActionResult Index()
        {
            // putting the movieinfo(response) of the moviesContext table context object into a list of type "Movie"
            var TaskList = tasksContext.Tasks
                // getting the Cateogry object associated with that movie (through the CategoryID FK relationship)
                //.Include(x => x.Category)
                //making sure the movie hasn't been edited
                //.Where(x => x.Edited != true)
                // ordering by Title
                .OrderBy(x => x.TaskId)
                .ToList();
            

            // putting that MovieList into the View function as "context" for the page
            return View(TaskList);
        }
        [HttpGet]//get method and result
        public IActionResult AddTask()
        {
            ViewBag.Categories = tasksContext.Category.ToList();

            return View();
        }
        [HttpPost]//post method and result
        public IActionResult AddTask(Tasks ar)
        {
            if (ModelState.IsValid)
            {
                tasksContext.Add(ar);
                tasksContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Majors = tasksContext.Category.ToList();

                return View(ar);
            }
        }
        [HttpGet]
        public IActionResult Edit(int taskId)
        {
            ViewBag.Categories = tasksContext.Category.ToList();

            var entry = tasksContext.Tasks
                .Single(tasks_context => tasks_context.TaskId == taskId);

            return View("Index", entry);
        }
        [HttpPost]
        public IActionResult Edit(Tasks blah)
        {
            tasksContext.Update(blah);
            tasksContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int taskId)
        {
            var entry = tasksContext.Tasks
                .Single(tasks_context => tasks_context.TaskId == taskId);

            return View(entry);
        }
        [HttpPost]
        public IActionResult Delete(Tasks ar)
        {
            tasksContext.Tasks.Remove(ar);
            tasksContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
