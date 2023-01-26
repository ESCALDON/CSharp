using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Proyecto_V
{
    class ClassNumeroEntero
    {
        static private int Numero { get; set; }
        public ClassNumeroEntero()
        {
            
        }
        static public int GetNumeroEntero()
        {
            return Numero;
        }
        public void SetNumeroEntero()
        {
            Numero = PedirNumeroEntero();
        }
        static public int PedirNumeroEntero()
        {
            Console.Clear();
            Boolean Completo = false;
            int NumeroEntero;
            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca el numero entero: ");
                if (int.TryParse(Console.ReadLine(), out NumeroEntero))
                {
                    Completo = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("ERROR: Debe introducir un número entero. \nIntentelo de nuevo");
                    Console.ReadKey();
                }
            } while (!Completo);

            return (NumeroEntero);
        }
        static public void MenuEntero()
        {
            ConsoleKeyInfo option;
            do
            {
                ShowMenu();
                option = Console.ReadKey(true);
                switch (option.KeyChar)
                {
                    case '1': CalcularPrimo(GetNumeroEntero()); break;
                    case '2': CalcularFactorial(GetNumeroEntero()); break;
                    case '3': CambioAHorasDeSegundos(GetNumeroEntero()); break;
                    case '4': Primeros15NumSeriePell(GetNumeroEntero()); break;
                    case '5': NumeroArmstrong(GetNumeroEntero()); break;
                    case '6': ComprobarNumeroDistintos(GetNumeroEntero()); break;
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
            Console.WriteLine("- 1. Calcular primo.                          -");
            Console.WriteLine("- 2. Calcular factorial.                      -");
            Console.WriteLine("- 3. Cambio de segundos a horas.              -");
            Console.WriteLine("- 4. Primeros 15 numeros de la serie de Pell. -");
            Console.WriteLine("- 5. Numero de Armstrong.                     -");
            Console.WriteLine("- 6. Comprobar si los digitos son distintos.  -");
            Console.WriteLine("- 7. Salir                                    -");
            Console.WriteLine("-----------------------------------------------");
        }
        static public void CalcularPrimo(int Numero)
        {

        }
        static public void CalcularFactorial(int Numero)
        {

        }
        static public void CambioAHorasDeSegundos(int Numero)
        {

        }
        static public void Primeros15NumSeriePell(int Numero)
        {

        }
        static public void NumeroArmstrong(int Numero)
        {

        }
        static public void ComprobarNumeroDistintos(int Numero)
        {

        }
    }
}
