using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN2
{
    public class Operaciones // Esta es la clase publicadora
    {
        public delegate void Delegado(int n); // lafirma del deleado debe ocnincidir con la del Manejador de eventod
        public event Delegado CuandoRecibaMultiplosCinco; //evento aqui se suscriben lo manejadores de eventos 
        public int Sumar(int x, int y)
        {
            int iSuma = x + y;
            if ((iSuma % 5 == 0) && (CuandoRecibaMultiplosCinco != null)) // cuando ocurre el evento de sermultiplo de 5 tenemos que llamar a evento para dispare enlos suscriptores
            { CuandoRecibaMultiplosCinco(iSuma); }
            return iSuma;
        }
    }
    class ProgramaEvento
    {
        static void Main()
        {
            Operaciones o = new Operaciones();
            o.CuandoRecibaMultiplosCinco += RecibeMultiploCinco;// nos estamos suscribiendo a eventoy mandandoalmanejador de eventos
            o.CuandoRecibaMultiplosCinco += RecibeMultiploCinco;// nos estamos suscribiendo a eventoy mandandoalmanejador de eventos

            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int res = o.Sumar(a, b);
            Console.WriteLine("La suma es = {0}", res);
            Console.ReadKey();
        }
        static void RecibeMultiploCinco(int n) // Manejador de Evento
        {
        }
    }
}

   