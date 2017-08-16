using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

//parts taken from 
//https://stackoverflow.com/questions/6694098/using-asp-net-mvc-with-classic-ado-net

namespace WebApplication5.Controllers
{
  
  public class UsersController : Controller
    {
    
    private readonly IUsersRepository _repository;
    public UsersController(IUsersRepository repository)
    {
      _repository = repository;
    }

    public ActionResult Index(int id)
    {
      var model = _repository.GetTableData();
      return View(model);
    }
  }
}