using Microsoft.AspNetCore.Mvc;
using MonsterTamersJourneyWebsite.Models;
using System.Diagnostics;

namespace MonsterTamersJourneyWebsite.Controllers
{
    public class HomeController : Controller
    {

        private AdminContex context { get; set; }

        public HomeController(AdminContex ctx) => context = ctx;

        [HttpGet]
        public IActionResult Index()
        {
            var news = context.News.OrderBy(m => m.NewsId).ToList();
            return View(news);
        }
        [HttpPost]
        public IActionResult Index(News news)
        {
            
            return View(news);
        }
        [HttpGet]
        public IActionResult Media()
        {

            var media = context.Media.OrderBy(m => m.Order).ToList();
            return View(media);
        }
        [HttpGet]
        public IActionResult News()
        {
            var news = context.News.OrderBy(m => m.NewsId).ToList();
            return View(news);
        }
        [HttpGet]
        public IActionResult Support()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Support(SupportRequest support)
        {
            return View();
        }
        [HttpGet]
        public IActionResult FAQ()
        {
            var faq = context.FAQ.OrderBy(m => m.FAQId).ToList();
            return View(faq);
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View(new SupportRequest());
        }
        [HttpGet]
        public IActionResult PressSignUp()
        {
            return View(new Press());
        }


        [HttpPost]
        public IActionResult SavePressSignUp(Press press)
        {
            context.Press.Add(press);
            context.SaveChanges();

            return RedirectToAction("Press");
        }

        [HttpPost]
        public IActionResult SaveContact(SupportRequest request)
        {
            context.SupportRequest.Add(request);
            context.SaveChanges();

            return RedirectToAction("Support");
        }


        [HttpPost]
        public IActionResult SaveCreatorSignUp(Creator creator)
        {
            context.Creator.Add(creator);
            context.SaveChanges();

            return RedirectToAction("Press");
        }

        [HttpGet]
        public IActionResult CreatorSignUp()
        {
            return View(new Creator());
        }
        public IActionResult Press()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}