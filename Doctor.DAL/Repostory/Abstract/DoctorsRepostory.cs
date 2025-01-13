using Doctor.DAL.Context;
using Doctor.DAL.Repostory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.DAL.Repostory.Abstract
{
    public  class DoctorsRepostory(DoctorsDbContext _context): IDoctorsRepostory
    {

    }
}
