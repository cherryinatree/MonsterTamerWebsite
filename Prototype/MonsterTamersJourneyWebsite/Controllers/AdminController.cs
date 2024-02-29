using Microsoft.AspNetCore.Mvc;
using MonsterTamersJourneyWebsite.Models;
using System;

namespace MonsterTamersJourneyWebsite.Controllers
{
    public class AdminController : Controller
    {


        private AdminContex context { get; set; }

        public AdminController(AdminContex ctx) => context = ctx;

        [HttpPost]
        public IActionResult SaveFAQEdits(FAQ FAQs)
        {
            var ListFAQ = context.FAQ.OrderBy(m => m.FAQId).ToList();
            int id = -1;
            int orderList = -1;
            int location = -1;

            int newFAQLocation = -1;
            int newFAQOrder = -1;

            for (int i = 0; i < context.FAQ.Count(); i++)
            {
                if (ListFAQ[i].Order == FAQs.Order && ListFAQ[i].FAQId != FAQs.FAQId)
                {
                    id = ListFAQ[i].FAQId;
                    orderList = ListFAQ[i].Order;
                    location = i;
                }

                if(ListFAQ[i].FAQId == FAQs.FAQId)
                {
                    newFAQLocation = i;
                    newFAQOrder = ListFAQ[i].Order;
                    ListFAQ[i].Order = FAQs.Order;
                    ListFAQ[i].Title = FAQs.Title;
                    ListFAQ[i].Content = FAQs.Content;
                }
            }

            if(id > -1)
            {
                ListFAQ[location].Order = newFAQOrder;
                context.FAQ.Update(ListFAQ[location]);
                context.FAQ.Update(ListFAQ[newFAQLocation]);
            }
            else
            {

                context.FAQ.Update(ListFAQ[newFAQLocation]);
            }


            context.SaveChanges();


            return RedirectToAction("AdminFAQRemove");
        }


        [HttpGet]
        public IActionResult SaveFAQRemove(int id)
        {
            Console.WriteLine(id);
            var faq = context.FAQ.Find(id);
            int order = faq.Order;


            context.FAQ.Remove(faq);
            context.SaveChanges();
            return RedirectToAction("AdminFAQRemove");
        }

        [HttpPost]
        public IActionResult SaveFAQAdd(FAQ FAQs)
        {
            
            context.FAQ.Add(FAQs);
            context.SaveChanges();

            return RedirectToAction("AdminFAQRemove");
        }

        public IActionResult AdminHub()
        {
            return View();
        }
        public IActionResult AdminCreatorList()
        {
            var ListCreator = context.Creator.OrderBy(m => m.CreatorId).ToList();
            return View(ListCreator);
        }
        public IActionResult AdminCreatorDetails(int id)
        {
            var creator = context.Creator.Find(id);
            return View(creator);
        }


        [HttpGet]
        public IActionResult SaveCreatorRemove(int id)
        {
            var creator = context.Creator.Find(id);


            context.Creator.Remove(creator);
            context.SaveChanges();
            return RedirectToAction("AdminCreatorList");
        }

        public IActionResult AdminPressList()
        {
            var ListPress = context.Press.OrderBy(m => m.PressId).ToList();
            return View(ListPress);
        }

        public IActionResult AdminPressDetails(int id)
        {
            var press = context.Press.Find(id);
            return View(press);
        }


        [HttpGet]
        public IActionResult SavePressRemove(int id)
        {
            var press = context.Press.Find(id);


            context.Press.Remove(press);
            context.SaveChanges();
            return RedirectToAction("AdminPressList");
        }

        [HttpGet]
        public IActionResult AdminFAQEdit(int id)
        {
            var faq = context.FAQ.Find(id);
            return View(faq);
        }

        public IActionResult AdminFAQAdd()
        {

            return View(new FAQ());
        }

        [HttpGet]
        public IActionResult AdminFAQRemove()
        {
            var faq = context.FAQ.OrderBy(m => m.Order).ToList();
            return View(faq);
        }
        public IActionResult AdminMediaAdd()
        {
            return View(new Media());
        }
        public IActionResult AdminMediaEdit(int id)
        {
            var media = context.Media.Find(id);
            return View(media);
        }
        public IActionResult AdminMediaRemove()
        {
            var ListMedia = context.Media.OrderBy(m => m.MediaId).ToList();
            return View(ListMedia);
        }


        [HttpPost]
        public IActionResult SaveMediaEdits(Media media)
        {
            var ListMedia = context.Media.OrderBy(m => m.MediaId).ToList();
            int id = -1;
            int orderList = -1;
            int location = -1;

            int newFAQLocation = -1;
            int newFAQOrder = -1;

            for (int i = 0; i < context.Media.Count(); i++)
            {
                if (ListMedia[i].Order == media.Order && ListMedia[i].MediaId != media.MediaId)
                {
                    id = ListMedia[i].MediaId;
                    orderList = ListMedia[i].Order;
                    location = i;
                }

                if (ListMedia[i].MediaId == media.MediaId)
                {
                    newFAQLocation = i;
                    newFAQOrder = ListMedia[i].Order;
                    ListMedia[i].Order = media.Order;
                    ListMedia[i].Title = media.Title;
                    ListMedia[i].isImage = media.isImage;
                    ListMedia[i].ImageUrl = media.ImageUrl;
                    ListMedia[i].VideoUrl = media.VideoUrl;
                }
            }

            if (id > -1)
            {
                ListMedia[location].Order = newFAQOrder;
                context.Media.Update(ListMedia[location]);
                context.Media.Update(ListMedia[newFAQLocation]);
            }
            else
            {

                context.Media.Update(ListMedia[newFAQLocation]);
            }


            context.SaveChanges();


            return RedirectToAction("AdminMediaRemove");
        }


        [HttpGet]
        public IActionResult SaveMediaRemove(int id)
        {
            var media = context.Media.Find(id);


            context.Media.Remove(media);
            context.SaveChanges();
            return RedirectToAction("AdminMediaRemove");
        }

        [HttpPost]
        public IActionResult SaveMediaAdd(Media media)
        {

            context.Media.Add(media);
            context.SaveChanges();

            return RedirectToAction("AdminMediaRemove");
        }


        [HttpPost]
        public IActionResult SaveNewsEdits(News news)
        {
            var ListNews = context.News.OrderBy(m => m.NewsId).ToList();
            int id = -1;
            int orderList = -1;
            int location = -1;

            int newFAQLocation = -1;
            int newFAQOrder = -1;

            for (int i = 0; i < context.News.Count(); i++)
            {
                if (ListNews[i].Order == news.Order && ListNews[i].NewsId != news.NewsId)
                {
                    id = ListNews[i].NewsId;
                    orderList = ListNews[i].Order;
                    location = i;
                }

                if (ListNews[i].NewsId == news.NewsId)
                {
                    newFAQLocation = i;
                    newFAQOrder = ListNews[i].Order;
                    ListNews[i].Order = news.Order;
                    ListNews[i].Title = news.Title;
                    ListNews[i].ImageUrl = news.ImageUrl;
                    ListNews[i].Content = news.Content;
                }
            }

            if (id > -1)
            {
                ListNews[location].Order = newFAQOrder;
                context.News.Update(ListNews[location]);
                context.News.Update(ListNews[newFAQLocation]);
            }
            else
            {

                context.News.Update(ListNews[newFAQLocation]);
            }


            context.SaveChanges();


            return RedirectToAction("AdminNewsRemove");
        }

        [HttpGet]
        public IActionResult SaveNewsRemove(int id)
        {
            var news = context.News.Find(id);


            context.News.Remove(news);
            context.SaveChanges();
            return RedirectToAction("AdminNewsRemove");
        }

        [HttpPost]
        public IActionResult SaveNewsAdd(News news)
        {

            context.News.Add(news);
            context.SaveChanges();

            return RedirectToAction("AdminNewsRemove");
        }

        public IActionResult AdminNewsEdit(int id)
        {

            var news = context.News.Find(id);
            return View(news);
        }
        public IActionResult AdminNewsAdd()
        {
            return View(new News());
        }
        public IActionResult AdminNewsRemove()
        {
            var ListNews = context.News.OrderBy(m => m.Order).ToList();
            return View(ListNews);
        }
        public IActionResult AdminSupportList()
        {
            var ListSupport = context.SupportRequest.OrderBy(m => m.SupportRequestId).ToList();
            return View(ListSupport);
        }
    }
}
