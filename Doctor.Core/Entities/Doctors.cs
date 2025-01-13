using Doctor.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.Core.Entities;

public class Doctors:BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime Birthday { get; set; }
    public bool IsFemale { get; set; }
    public string ImageUrl { get; set; }
    public string Activity {  get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}
