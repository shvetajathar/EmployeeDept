namespace EMS.Controllers;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Models;
public class DeptController : Controller
{
    private readonly ApplicationDbContext context;
    public DeptController(ApplicationDbContext _context)
    {
        context = _context;
    }
    public IActionResult Display(int Id)
    {
        var data = context.Employees.Where(e => e.DeptId == Id);

        return View(data);
    }
    public IActionResult List()
    {
        List<Dept> data = null;
        // try
        // {
            data = context.Depts.ToList();
            // if (data.Count == 0)
                // throw new Exception();
        // }
        // catch (System.Exception ex)
        // {
        //     ViewBag.ErrorMessage = "0 records present";
        //     return View("Error");
        // }
        return View(data);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Dept dept)
    {
        // try
        // {
        //     if (ModelState.IsValid)
        //     {
                context.Depts.Add(dept);
                context.SaveChanges();
                return RedirectToAction("List");
        //     }
        // }
        // catch (System.Exception ex)
        // {
        //     ViewBag.ErrorMessage = ex.Message;
        //     return View("Error");


        //     throw;
        // }

        // return View();
    }
}