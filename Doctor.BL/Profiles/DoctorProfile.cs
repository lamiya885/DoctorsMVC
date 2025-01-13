using AutoMapper;
using Doctor.Core.Entities;
using Doctor.MVC.ViewModel.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.BL.Profiles;

public class DoctorProfile : Profile
{
    public DoctorProfile()
    {
        CreateMap<CreateDoctorVM, Doctors>();
        CreateMap<UpdateDoctorVM,Doctors>();
    }
}
