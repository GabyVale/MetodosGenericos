using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            calculadora<int> calcu = new calculadora<int>();
            Console.WriteLine(calculadora<int>.sum(3,2));
            Console.ReadKey();
        }
    }
        
    }

