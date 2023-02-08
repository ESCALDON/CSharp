using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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

            if (secondHalf==FirstHalf)
            {
                Console.Clear();
                Console.WriteLine("Es un palindromo!");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No es un palindromo :(");
                Console.ReadKey();
            }
        }
        public void PasarAMinúsculas()
        {
            string Cadena;
            string CadenaMinus;
            Boolean Completo = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca una cadena para pasar a minúscula: ");
                Cadena = Console.ReadLine();
                if (Cadena != "")
                {
                    bool tieneMayusculas = Cadena.Any(c => char.IsUpper(c));
                    if (tieneMayusculas == true)
                    {
                        Completo = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\tERROR:Debe contener al menos una mayúscula, intentelo de nuevo.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\tERROR:No puede dejar este campo vacio, intentelo de nuevo.");
                    Console.ReadKey();
                }
            } while (!Completo);

            CadenaMinus=Cadena.ToLower();

            Console.Clear();
            Console.WriteLine(CadenaMinus);
            Console.ReadKey();
        }
        public void CuantasRepeticionLetra()
        {
            string Cadena;
            string Caracter;
            string Aux = "";
            int Contador = 0;
            Boolean Completo = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca una cadena: ");
                Cadena = Console.ReadLine();
                if (Cadena != "")
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
                
            Completo= false;

            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca un carácter que este en la cadena anterior: ");
                Caracter = Console.ReadLine();
                if (Caracter != "")
                {
                    if (Caracter.Length==1)
                    {
                        Completo = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\tERROR:Debe introducir solo un carácter, intentelo de nuevo.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\tERROR:No puede dejar este campo vacio, intentelo de nuevo.");
                    Console.ReadKey();
                }
            } while (!Completo);

            for (int i = 0; i < Cadena.Length; i++)
            {
                char caracter = Cadena[i];
                Aux = Aux + caracter;

                if (Cadena.Contains(Caracter))
                {
                    Contador++;
                    Aux = "";
                }
            }
            if (Contador>0)
            {
                Console.Clear();
                Console.WriteLine("Contiene {0} veces el caracter {1}",Contador,Caracter);
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("La cadena no contiene el carácter");
                Console.ReadKey();
            }
        }
        public void RepetirCadena()
        {
            string Cadena1;
            string Cadena2;
            int NumeroRepeticiones;
            Boolean Completo = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca una cadena: ");
                Cadena1 = Console.ReadLine();
                if (Cadena1 != "")
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

            Completo = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca una segunda cadena: ");
                Cadena2 = Console.ReadLine();
                if (Cadena2 != "")
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

            Completo = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca la cantidad de veces que desea repetir la cadena: ");
                if (int.TryParse(Console.ReadLine(),out NumeroRepeticiones))
                {
                    if (NumeroRepeticiones>0)
                    {
                        Completo = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\tERROR: No estan permitidos los valores negativos, intentelo de nuevo.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\tERROR: Debe introducir un número entero, intentelo de nuevo.");
                    Console.ReadKey();
                }
            } while (!Completo);

            Console.Clear();
            for (int i = 0; i < NumeroRepeticiones; i++)
            {
                Console.Write(Cadena1 + Cadena2 + " ");
            }
            Console.ReadKey();
        }
        public void RepetirLetra()
        {
            string Cadena;
            Boolean Completo = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca una cadena: ");
                Cadena = Console.ReadLine();
                if (Cadena != "")
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

            Console.Clear();
            for (int i = 0; i < Cadena.Length; i++)
            {
                Console.WriteLine(Cadena[i] + Cadena[i]);
            }
            Console.ReadKey();
        }
        public void BorrarPalabraTexto()
        {
            string Cadena;
            string Palabra;
            string CadenaBorrada;
            Boolean Completo = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca un texto del que desee borrar una palabra: ");
                Cadena = Console.ReadLine();
                if (Cadena != "")
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

            Completo = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca la palabra a borrar: ");
                Palabra = Console.ReadLine();
                if (Palabra != "")
                {
                    for (int i = 0; i < Palabra.Length; i++)
                    {
                        if (!Palabra[i].Equals(" "))
                        {
                            Completo = true;
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\tERROR:No puede dejar este campo vacio, intentelo de nuevo.");
                    Console.ReadKey();
                }
            } while (!Completo);

            CadenaBorrada=Cadena.Replace(Palabra,string.Empty);

            Console.Clear();
            Console.WriteLine(CadenaBorrada);
            Console.ReadKey();
        }
    }
}
