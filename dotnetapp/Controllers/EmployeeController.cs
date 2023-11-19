using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using dotnetapp.Models;
namespace dotnetapp.Controllers;
public class EmployeeController:Controller{
    private readonly ApplicationDbContext context;
    public EmployeeController(ApplicationDbContext _context){
        context=_context;
    }

    public IActionResult Index()
    {
        var data=context.Employees.ToList();
        return View(data);
        
    }


    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Employee employee)
    {
        if(ModelState.IsValid)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        return View();
    }
    public IActionResult Edit(int id)
    {
        return View();

        


    }

    public IActionResult Delete(int id)
    {
        return View();
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        if(ModelState.IsValid)
        {
            var data=context.Employees.Find(id);
            context.Employees.Remove(data);
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
