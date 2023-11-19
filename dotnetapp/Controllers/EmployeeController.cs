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
    public IActionResult List(){
        // var data=context.Employees.ToList();
        var data=context.Employees.Include("Dept").ToList();
        return View(data);
    }
    public IActionResult Create(){
        ViewBag.DeptId=new SelectList(context.Depts,"Id","Name");
        return View();
    }
    [HttpPost]
    public IActionResult Create(Employee emp){
        // if(ModelState.IsValid)
        {
            context.Employees.Add(emp);
            context.SaveChanges();
            return RedirectToAction("List");
        }
        ViewBag.DeptId=new SelectList(context.Depts,"Id","Name");
        return View(emp);
    }
}
