using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ng_projects.Manager;

public class Command : Entity
{
    public string Name { get; set; }
    public int Age { get; set; }
}
