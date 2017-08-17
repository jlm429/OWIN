using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{

    
    public class HomeController : Controller
    {

        public HomeController()
        {
            
        }



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IUsersRepository _repository = new UsersRepository();
            //ViewBag.Message = "About page.";
            ViewBag.Message = _repository.GetTableData();


            return View();
        }

    [Authorize]
    public ActionResult Contact()
        {
            
            ViewBag.Message = "Example Application.";
            return View();
        }
    }
}