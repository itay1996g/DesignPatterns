﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    public interface ISort
    {
        void Sort(IList<int> list);
    }
}
