﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace show
{
    class Program
    {
     public static int Somar (int x, int y)
        {
            return x + y;
        }
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }
         public static int multiplicar(int x, int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Resultado da soma: {0}+{1}",3,5,Somar(3,5));
            Console.WriteLine("Resultado da subtração: {0} + {1}", 3, 5, Subtrair(3, 5));
            Console.WriteLine("Resultado da Multiplicação: {0} + {1} = {2}", 3, 5, multiplicar(3, 5));
        }

    }
}
