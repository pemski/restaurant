﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public interface IHistoryManagement
    {
        void Save(HistoryData data, Order order);
        string Load();
    }
}