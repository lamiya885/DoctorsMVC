using AutoMapper;
using Doctor.Core.Entities;
using Doctor.MVC.ViewModel.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.BL.Profiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<CreateDepartmentVM, Department>();
            CreateMap<UpdateDepartmentVM,Department>();
        }
    }
}
