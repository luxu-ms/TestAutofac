using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestAutofac.Controllers
{
    public class HomeController : Controller
    {
        public interface IMessageService
        {
            string GetMessage();
        }

        public class MessageService : IMessageService
        {
            public string GetMessage()
            {
                return "Hello from Autofac!";
            }
        }

        private readonly IMessageService _messageService;

        public HomeController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public ActionResult Index()
        {
            ViewBag.Message = _messageService.GetMessage();
            return View();
        }

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}