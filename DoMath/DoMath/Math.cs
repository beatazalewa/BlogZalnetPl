﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoMath
{
    public class Math : IDoMath
    {
        public int Add(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }

        public int Multiply(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }

    }
}
