using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WindowsFormsApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection fc, string userId)
        {
            ViewBag.JavaScript = "<script>alert('Save successfully.');window.location = '/Account/Login';</script>";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult Test1(object username)
        {
            string str = "Jaimin";
            string str1 = "";
            if (str == username.ToString())
            {
                str1 = "Already Exist";
            }
            else
            {
                str1 = "Someone already has that username. Try another?";
            }
            
            return Json(str1);
                
        }
        
        public string Test(object username)
        {
            //System.Threading.Thread.Sleep(20000);
            string str = "Jaimin";
            string str1 = "";
            if (str == username.ToString())
            {
                str1 = "Already Exist";
            }
            else
            {
                str1 = "Someone already has that username. Try another?";
            }
            return str1;
        }
    }
}
