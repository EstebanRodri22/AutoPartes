﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public interface IBaseEntity
    {
        string Id { get; set; }
        string Descripcion { get; set; }
    }
}
