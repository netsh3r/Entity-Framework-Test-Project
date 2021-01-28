using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ng_projects.Manager;

public class User : Entity 
{
    public string Name { get; set; }
    public int Age { get; set; }
}
