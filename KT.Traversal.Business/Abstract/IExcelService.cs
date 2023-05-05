﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.Traversal.Business.Abstract
{
    public interface IExcelService
    {
        byte[] ExcelList<T>(List<T> list) where T : class;
    }
}
