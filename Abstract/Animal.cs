﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Animal
    {

        public abstract void Talk();

        public virtual int LegN { get; set; }

    }
}
