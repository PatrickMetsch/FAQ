using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FAQ.Models;
using Microsoft.EntityFrameworkCore;

namespace FAQ.Controllers
{
    public class HomeController : Controller
    {
        private QuestionContext context { get; set; }

        public HomeController(QuestionContext ctx)
        {
            context = ctx;    
        }

        public IActionResult Index(string topic = "all", string category = "all")
        {
            var questions = context.Questions.Include(c => c.Category).Include(t => t.Topic).OrderBy(q => q.QuestionId).ToList();
            var topicSort = topic;
            var categorySort = category;

            if(topic != "all")
            {
                questions = questions.FindAll(q => q.Topic.TopicName == topic);
            }

            if(category != "all")
            {
                questions = questions.FindAll(q => q.Category.CategoryName == category);
            }
            return View(questions);
        }
    }
}
