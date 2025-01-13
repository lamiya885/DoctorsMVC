﻿using Doctor.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.Core.Entities;

public  class Department:BaseEntity
{
    public string Name { get; set; }
    public IEnumerable<Doctors> Doctors { get; set; }
}
