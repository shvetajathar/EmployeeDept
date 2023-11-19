using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.Models;
public class Employee
{
    [Key]
    public int EmployeeId{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    [ForeignKey("Department")]
    public int DepartmentId{get;set;}
    public Department Department{get;set;}
    
    
}