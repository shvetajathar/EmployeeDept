using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.Models;
public class Department
{
    [Key]
    public int DepartmentId{get;set;}
    public string Name{get;set;}
    
    public ICollection<Employee> Employee{get;set;}
}