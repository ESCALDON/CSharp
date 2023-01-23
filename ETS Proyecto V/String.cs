using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Proyecto_V
{
    class String
    {
        static public void MenuString()
        {
            ConsoleKeyInfo option;
            do
            {
                ShowMenu();
                option = Console.ReadKey(true);
                switch (option.KeyChar)
                {
                    case '1': CalcularPrimo(); break;
                    case '2': CalcularFactorial(); break;
                    case '3': CambioAHorasDeSegundos(); break;
                    case '4': Primeros15NumSeriePell(); break;
                    case '5': NumeroArmstrong(); break;
                    case '6': ComprobarNumeroDistintos(); break;
                }
            } while (!option.KeyChar.Equals('7'));

        }
        static private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-               Menu de Arrays                -");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("- Elige entre siguientes opciones             -");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("- 1. Palindromo.                          -");
            Console.WriteLine("- 2. Calcular factorial.                      -");
            Console.WriteLine("- 3. Cambio de segundos a horas.              -");
            Console.WriteLine("- 4. Primeros 15 numeros de la serie de Pell. -");
            Console.WriteLine("- 5. Numero de Armstrong.                     -");
            Console.WriteLine("- 6. Comprobar si los digitos son distintos.  -");
            Console.WriteLine("- 7. Salir                                    -");
            Console.WriteLine("-----------------------------------------------");
        }
        static public void CalcularPrimo()
        {

        }
        static public void CalcularFactorial()
        {

        }
        static public void CambioAHorasDeSegundos()
        {

        }
        static public void Primeros15NumSeriePell()
        {

        }
        static public void NumeroArmstrong()
        {

        }
        static public void ComprobarNumeroDistintos()
        {

        }
    }
}
