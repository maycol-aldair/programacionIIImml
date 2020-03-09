using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Memor de {0}, {1} y {2} es {3}\n",
                    
                    2, 3, 4, Menor( 1 2, 3, 4));
                Console.WriteLine("Menor de {0}, {1} y {2} es {3}\n",
                   3.1, 4.6, 2.3, Menor(1.3, 4.6, 2.3));
                Console.WriteLine("Menor de {0}, {1} y {2} es {3}\n",
                   "juan ", "pedro", "maria", Menor("juan ", "pedro ", " maria"));
                Console.ReadKey();
            }
        }
        private static T Menor<T>(T x, T y, T z)
           where T : IComparable<T>
        {
            T max = x; //
            if (y.CompareTo(max) > 0)
                max = y; 
            
            if (z.CompareTo(max) > 0)
                max = z; 
            return max; 
        }
    }
}
