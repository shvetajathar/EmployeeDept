using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using dotnetapp.Models;
namespace dotnetapp.Controllers;
public class DepartmentController:Controller{
    private readonly ApplicationDbContext context;
    public DepartmentController(ApplicationDbContext _context){
        context=_context;
    }

    public IActionResult Index()
    {
        var data=context.Departments.ToList();
        return View(data);
    }


    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Department department)
    {
        if(ModelState.IsValid)
        {
            context.Departments.Add(department);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        return View();
    }

    public IActionResult Delete()
    {
        return View();
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        if(ModelState.IsValid)
        {
            var data=context.Departments.Find(id);
            context.Departments.Remove(data);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        return View();
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(Department dept)
    {
        
            Department data=context.Departments.Find(dept.DepartmentId);
            if(data==null)
            {
                return NotFound();
            }
            return View();
           
        

       
    }






    

}
