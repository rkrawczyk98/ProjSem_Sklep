﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSem_Sklep_Lib.Models
{
    public abstract class BaseModel : IEntity
    {
        public int ID { get; set; }
    }
}
