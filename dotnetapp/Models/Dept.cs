using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.Models;
public class Dept
{
    [Key]
    public int Id{get;set;}
    public string Name{get;set;}
    
    public ICollection<Employee> Employee{get;set;}
}