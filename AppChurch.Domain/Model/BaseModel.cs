﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChurch.Domain.Entities
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }
    }
}
