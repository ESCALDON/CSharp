using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Proyecto_V
{
    class Menu
    {
        private Array myArrayList;
        private NumeroEntero myEnteroList;
        public Menu()
        {
            this.myArrayList = new Array();
            this.myEnteroList = new NumeroEntero();
            ConsoleKeyInfo option;
            do
            {
                this.ShowMenu();
                option = Console.ReadKey(true);
                switch (option.KeyChar)
                {
                    case '1': myArrayList.GetNumerosArray();myArrayList.GetTamanioArray();myArrayList.MenuArray() ; break;
                    case '2': myEnteroList.GetNumeroEntero();myEnteroList.MenuEntero(); break;
                    case '3':; break;
                    case '4':; break;
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
