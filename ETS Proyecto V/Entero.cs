using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Proyecto_V
{
    class NumeroEntero
    {
        private int Numero { get; set; }
        public NumeroEntero()
        {
            Console.Clear();
            this.Numero = PedirNumeroEntero();
        }
        public int GetNumeroEntero()
        {
            return (this.Numero);
        }
        public void SetNumeroEntero()
        {
            this.Numero = PedirNumeroEntero();
        }
        public int PedirNumeroEntero()
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
        public void MenuEntero()
        {
            ConsoleKeyInfo option;
            do
            {
                this.ShowMenu();
                option = Console.ReadKey(true);
                switch (option.KeyChar)
                {
                    case '1': CalcularPrimo(Numero); break;
                    case '2': CalcularFactorial(Numero); break;
                    case '3': CambioAHorasDeSegundos(Numero); break;
                    case '4': Primeros15NumSeriePell(Numero); break;
                    case '5': NumeroArmstrong(Numero); break;
                    case '6': ComprobarNumeroDistintos(Numero); break;
                }
            } while (!option.KeyChar.Equals('7'));

        }
        private void ShowMenu()
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
        public void CalcularPrimo(int Numero)
        {

        }
        public void CalcularFactorial(int Numero)
        {

        }
        public void CambioAHorasDeSegundos(int Numero)
        {

        }
        public void Primeros15NumSeriePell(int Numero)
        {

        }
        public void NumeroArmstrong(int Numero)
        {

        }
        public void ComprobarNumeroDistintos(int Numero)
        {

        }
    }
}
