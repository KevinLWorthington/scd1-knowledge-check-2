﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdc1_knowledge_check_2.Class
{
    internal class Trial : Orders
    {
        string? Qcs { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", QCS: {Qcs}";
        }
    }
}
