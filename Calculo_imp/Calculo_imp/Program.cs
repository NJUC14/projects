using System;

namespace Calculo_imp
{ 
    class Program
    {
        static void Main(string[] args)
        {

            double vSueldob, neto, imp;

            Console.WriteLine("Ingrese su sueldo: ");
            vSueldob = Convert.ToInt32(Console.ReadLine());

            double AFP = vSueldob * 0.07, ISR = vSueldob * 0.09, SSF = vSueldob * 0.10;

            imp = AFP + ISR + SSF;

            neto = vSueldob - imp;

            Console.WriteLine("Su sueldo neto es de: " + neto);



        }
    }
}
