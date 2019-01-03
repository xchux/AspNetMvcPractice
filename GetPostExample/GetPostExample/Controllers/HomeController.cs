using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetPostExample.Models;
namespace GetPostExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DateTime date = DateTime.Now;
            ViewBag.Date = date;

            Student data = new Student("1", "小明", 80);
            return View(data);
        }

        public ActionResult Transcripts(string id, string name, int score)
        {
            Student data = new Student(id, name, score);
            return View(data);
        }

        [HttpPost]
        public ActionResult Transcripts(FormCollection post)
        {
            string id = post["id"];
            string name = post["name"];
            int score = Convert.ToInt32(post["score"]);
            Student data = new Student(id, name, score);
            return View(data);
        }
    }
}