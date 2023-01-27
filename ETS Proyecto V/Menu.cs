using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Proyecto_V
{
    class Menu
    {
        ClassNumeroEntero ClassNumeroEnteros = new ClassNumeroEntero();
        Arrays ClassArrays = new Arrays();
        ClassString ClassStrings = new ClassString();
        ClassDecimal ClassDecimals = new ClassDecimal();
        public Menu()
        {
            ConsoleKeyInfo option;
            do
            {
                this.ShowMenu();
                option = Console.ReadKey(true);
                switch (option.KeyChar)
                {
<<<<<<< HEAD
                    case '1': ClassArrays.MenuArray(); break;
                    case '2': ClassNumeroEnteros.MenuEntero(); break;
                    case '3': ClassStrings.MenuString(); break;
                    case '4': ClassDecimals.MenuDecimal(); break;
=======

                    case '1': Arrays.MenuArray(); break;
                    case '2': NumeroEntero.MenuEntero(); break;
                    case '3': String.MenuString(); break;
                    case '4': Decimal.MenuDecimal(); break;

>>>>>>> IvanBckp
                }
            } while (!option.KeyChar.Equals('5'));

        }
        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-         Calculos matemáticos          -");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- Elige entre siguientes opciones       -");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- 1. Array.                             -");
            Console.WriteLine("- 2. Numero.                            -");
            Console.WriteLine("- 3. String.                            -");
            Console.WriteLine("- 4. Decimales.                         -");
            Console.WriteLine("- 5. Salir                              -");
            Console.WriteLine("-----------------------------------------");
        }

        public void Bye()
        {
            Console.Clear();
            Console.Write("Pulsa una tecla para finalizar ....");
            Console.ReadKey();
        }
    }
}
