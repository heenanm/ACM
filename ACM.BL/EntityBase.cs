﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public abstract class EntityBase
    {
        public bool HasChanges { get; set; }    
        public bool IsNew { get; private set; }

        public bool IsValid
        {
            get { return true; }
        }

    }
}
