﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public interface IOperation
    {
        void Calculate(double num1, double num2, ref double result);
    }
}
