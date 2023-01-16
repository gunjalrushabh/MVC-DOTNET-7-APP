using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using storeapp.Models;

using BOL;
using BLL;
using DAL;
namespace storeapp.Controllers;

public class DepartmentController : Controller
{
    private readonly ILogger<DepartmentController> _logger;

    public DepartmentController(ILogger<DepartmentController> logger)
    {
        _logger = logger;
    }
[HttpGet]
    public IActionResult Index()
    {
        HRManager hobj=new HRManager();
        List<Department> list=HRManager.GetAlldepartmentfromDal();
        this.ViewData["departments"]=list;
               return View();
    }
    [HttpGet]
    public IActionResult Insert()
    {
        Department dobj=new Department();
        return View(dobj);
    }
    [HttpPost]
    public IActionResult Insert(int id,string name,string location)
    {
        // if(!ModelState.IsValid)
        // {
        //     return View();
        // }
        HRManager hobj=new HRManager();
        
        if(hobj.insert(id,name,location)){
        return RedirectToAction("Index");
        }
        return View();
    
    }

}