﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.Core.Entities.Common;

public  class BaseEntity
{
    public Guid Id { get; set; }    
    public DateTime CreatedTime { get; set; } =DateTime.Now;
    public DateTime UpdatedTime { get; set; }
    public bool IsDeleted { get; set; }
}
