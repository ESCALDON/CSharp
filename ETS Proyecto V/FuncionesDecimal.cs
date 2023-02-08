using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ETS_Proyecto_V
{
    class ClassDecimal
    {
        private decimal NumeroDecimal { get; set; }
        public ClassDecimal()
        {
            
        }
        public decimal GetNumeroDecimal()
        {
            return (NumeroDecimal);
        }
        public void SetNumeroDecimal()
        {
            NumeroDecimal = PedirNumeroDecimal();
        }
        public decimal PedirNumeroDecimal()
        {
            Console.Clear();
            Boolean Completo = false;
            decimal NumeroDecimal;
            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca el número decimal: ");
                if (decimal.TryParse(Console.ReadLine(), out NumeroDecimal))
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
                ShowMenu();
                option = Console.ReadKey(true);
                switch (option.KeyChar)
                {
                    case '1': RedondearAlAlza(GetNumeroDecimal()); break;
                    case '2': EliminarLosDecimales(GetNumeroDecimal()); break;
                    case '3': Ecuacion2Grado(); break;
                }
            } while (!option.KeyChar.Equals('4'));

        }
        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("-                         Menu de Decimal                             -");
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
            Console.Clear();
            Console.WriteLine("El resultado es: " + Math.Ceiling(NumeroDecimal));
            Console.ReadKey();
        }
        public void EliminarLosDecimales(decimal NumeroDecimal)
        {
            Console.Clear();
            Console.WriteLine("El resultado es: " + Math.Truncate(NumeroDecimal));
            Console.ReadKey();
        }
        public void Ecuacion2Grado()
        {
            Console.Clear();
            Boolean Completo = false;
            double[] NumeroDecimal = new double[3];
            double ResultadoPositivo;
            double ResultadoNegativo;

            for (int i = 0; i < NumeroDecimal.Length; i++)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Introduzca el {0} número decimal: ", i+1);
                    if (double.TryParse(Console.ReadLine(), out NumeroDecimal[i]))
                    {
                        Completo = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR: Debe introducir un número. \nIntentelo de nuevo");
                        Console.ReadKey();
                    }
                } while (!Completo);
            }

            ResultadoPositivo = (-NumeroDecimal[1] + Math.Sqrt(Math.Pow(NumeroDecimal[1], 2) - 4 * NumeroDecimal[0] * NumeroDecimal[2])) / (2 * NumeroDecimal[0]);
            ResultadoNegativo = (-NumeroDecimal[1] - Math.Sqrt(Math.Pow(NumeroDecimal[1], 2) - 4 * NumeroDecimal[0] * NumeroDecimal[2])) / (2 * NumeroDecimal[0]);

            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("-           Ecuacion 2 Grado           -");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("- Resultado positivo: {0}               ",ResultadoPositivo);
            Console.WriteLine("- Resultado negativo: {0}               ",ResultadoNegativo);
            Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}
