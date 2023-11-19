using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.Models;
public class Employee
{
    [Key]
    public int EmpId{get;set;}
    public string EmpName{get;set;}
    [ForeignKey("Dept")]
    public int deptId{get;set;}
    public Dept Dept{get;set;}
    
    
}