using Doctor.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.DAL.Configurations;

public class DoctorConfiguration : IEntityTypeConfiguration<Doctors>
{
  
    public void Configure(EntityTypeBuilder<Doctors> builder)
    {
        builder.HasIndex(o => o.Name);
        builder.HasIndex(o=>o.Surname);
        builder.HasIndex(o=>o.Birthday);
        builder.HasIndex(o=>o.ImageUrl);
        builder.HasIndex(o=>o.Activity);
        builder.HasOne(e => e.Department)
      .WithMany(e => e.Doctors)
      .HasForeignKey(e=>e.DepartmentId);

    }
}
