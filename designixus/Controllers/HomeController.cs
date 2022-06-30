using designixus.Models.ContactForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace designixus.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactModel model)
        {

           
                var body = new StringBuilder();
                body.AppendLine("E.mail: " + model.Email);
                Newsletter.SendMail(body.ToString());
                ViewBag.Success = true;
         

            return View();
        }

        public ActionResult Work()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Work(ContactModel model)
        {


            var body = new StringBuilder();
            body.AppendLine("E.mail: " + model.Email);
            Newsletter.SendMail(body.ToString());
            ViewBag.Success = true;


            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Services(ContactModel model)
        {


            var body = new StringBuilder();
            body.AppendLine("E.mail: " + model.Email);
            Newsletter.SendMail(body.ToString());
            ViewBag.Success = true;


            return View();
        }


        public ActionResult Contact()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Contact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                var body = new StringBuilder();
                body.AppendLine("İsim: " + model.Name);

                body.AppendLine("E.mail: " + model.Email);

                body.AppendLine("Telefon: " + model.Phone);

                body.AppendLine("Mesaj: " + model.Message);

                Form.SendMail(body.ToString());
                ViewBag.Success = true;
            }

            else
            {
                var body = new StringBuilder();
                body.AppendLine("E.mail: " + model.Email);
                Newsletter.SendMail(body.ToString());
                ViewBag.Success = true;
            }

            return View();
        }

    }
}