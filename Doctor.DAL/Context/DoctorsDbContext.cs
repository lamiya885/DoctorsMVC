using Doctor.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.DAL.Context;

public  class DoctorsDbContext:DbContext
{
    public DoctorsDbContext (DbContextOptions options):base(options)
    {

    }
    public DbSet<Doctors> Doctors { get; set; }
    public DbSet<Department> Departments { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
