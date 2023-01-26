using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Proyecto_V
{
    class ClassString
    {
        public void MenuString()
        {
            ConsoleKeyInfo option;
            do
            {
                ShowMenu();
                option = Console.ReadKey(true);
                switch (option.KeyChar)
                {
                    case '1': Palindromo(); break;
                    case '2': PasarAMinúsculas(); break;
                    case '3': CuantasRepeticionLetra(); break;
                    case '4': RepetirCadena(); break;
                    case '5': RepetirLetra(); break;
                    case '6': BorrarPalabraTexto(); break;
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
            Console.WriteLine("- 1. Palindromo.                              -");
            Console.WriteLine("- 2. Pasar a minúsculas.                      -");
            Console.WriteLine("- 3. Contar cuantas veces se repite una letra.-");
            Console.WriteLine("- 4. Repetir una cadena.                      -");
            Console.WriteLine("- 5. Repetir Letra.                           -");
            Console.WriteLine("- 6. Borrar una palabra de un texto.          -");
            Console.WriteLine("- 7. Salir                                    -");
            Console.WriteLine("-----------------------------------------------");
        }
        public void Palindromo()
        {
            string Cadena;
            Boolean Completo = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca un palindromo: ");
                Cadena = Console.ReadLine();
                if (Cadena!="")
                {
                    Completo = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\tERROR:No puede dejar este campo vacio, intentelo de nuevo.");
                    Console.ReadKey();
                }
            } while (!Completo);

            string FirstHalf = Cadena.Substring(0, Cadena.Length / 2);
            char[] Arr = Cadena.ToCharArray();

            Array.Reverse(Arr);

            string temp = new string(Arr);
            string secondHalf = temp.Substring(0, temp.Length / 2);
        }
        public void PasarAMinúsculas()
        {

        }
        public void CuantasRepeticionLetra()
        {

        }
        public void RepetirCadena()
        {

        }
        public void RepetirLetra()
        {

        }
        public void BorrarPalabraTexto()
        {

        }
    }
}
