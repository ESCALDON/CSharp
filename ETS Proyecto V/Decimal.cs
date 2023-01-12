using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Proyecto_V
{
    class Decimal
    {
        private decimal NumeroDecimal { get; set; }
        public Decimal()
        {
            Console.Clear();
            this.NumeroDecimal = PedirNumeroDecimal();
        }
        public decimal GetNumeroDecimal()
        {
            return (this.NumeroDecimal);
        }
        public void SetNumeroDecimal()
        {
            this.NumeroDecimal = PedirNumeroDecimal();
        }
        public int PedirNumeroDecimal()
        {
            Console.Clear();
            Boolean Completo = false;
            int NumeroDecimal;
            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca el tamaño del array: ");
                if (int.TryParse(Console.ReadLine(), out NumeroDecimal))
                {
                    Completo= true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("ERROR: Debe introducir un número. \nIntentelo de nuevo");
                    Console.ReadKey();
                }
            } while (!Completo);

            return (NumeroDecimal);
        }
        public void MenuDecimal()
        {
            ConsoleKeyInfo option;
            do
            {
                this.ShowMenu();
                option = Console.ReadKey(true);
                switch (option.KeyChar)
                {
                    case '1': RedondearAlAlza(NumeroDecimal); break;
                    case '2': EliminarLosDecimales(NumeroDecimal); break;
                    case '3': Ecuacion2Grado(NumeroDecimal); break;
                }
            } while (!option.KeyChar.Equals('4'));

        }
        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("-                         Menu de Arrays                             -");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("- Elige entre siguientes opciones                                    -");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("- 1. Redondear el número al alza.                                    -");
            Console.WriteLine("- 2. Eliminar los decimales del número.                              -");
            Console.WriteLine("- 3. Dados tres coeficientes ejecutar la ecuación de segundo grado.  -");
            Console.WriteLine("- 4. Salir                                                           -");
            Console.WriteLine("----------------------------------------------------------------------");
        }
        public void RedondearAlAlza(decimal NumeroDecimal)
        {

        }
        public void EliminarLosDecimales(decimal NumeroDecimal)
        {

        }
        public void Ecuacion2Grado(decimal NumeroDecimal)
        {

        }
    }
}
