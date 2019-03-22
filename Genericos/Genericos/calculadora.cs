using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    public class calculadora <T> where T : struct // Asi indicamos que es una clase generica, ayuda a maximizar la reutilización de código
    {
        public T _a, _b;
        public calculadora(T i, T j)
        {
            _a = i;
            _b = j;
        }
        public calculadora()
        { }
        public static calculadora<T> operator +(calculadora<T> i, calculadora<T> j)
        {
            Console.WriteLine("Suma: ",sum(i._a, j._a), sum(i._b, j._b));
            return new calculadora<T>(sum(i._a, j._a), sum(i._b, j._b));
        }
        public static T sum(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }

    }
}
