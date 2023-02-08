using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Proyecto_V
{
    class ClassNumeroEntero
    {
        private int Numero { get; set; }
        public ClassNumeroEntero()
        {
            
        }
        public int GetNumeroEntero()
        {
            return Numero;
        }
        public void SetNumeroEntero()
        {
            Numero = PedirNumeroEntero();
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
        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-               Menu de Enteros               -");
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
        static public void CalcularPrimo()
        {
            int Numero;
            Console.WriteLine("Introduzca un número para saber si es primo: ");
            Numero = PedirNumero();
            int numeroVeces = 0;
            for (int i = 1; i <= Numero; i++)
            {
                if (Numero % i == 0)
                {
                    numeroVeces++;
                }
            }
            if (numeroVeces == 2)
            {
                Console.WriteLine("El número {0} es primo!", Numero);
            }
            else
            {
                Console.WriteLine("El número {0} NO es primo!", Numero);
            }
            Console.ReadKey();
        }
        static public void CalcularFactorial()
        {
            int Numero;
            Console.WriteLine("Introduzca un número para calcular el factorial: ");
            Numero = PedirNumero();
            int factorial = 0;
            for (int i = Numero - 1; i >= 1; i--)
            {
                if (i == Numero - 1)
                {
                    factorial = Numero;
                    factorial = factorial * i;
                }
                else
                {
                    factorial = factorial * i;
                }
            }
            Console.WriteLine("Factorial de {0}: {1}", Numero, factorial);
            Console.ReadKey();
        }
        static public void CambioAHorasDeSegundos()
        {
            int segundos = 0;
            int restosegundos = 0;
            int horas;

            int minutos;

            Console.WriteLine("Introduzca el número de Segundos que quiera convertir: ");
            segundos = PedirSegundos();
            horas = segundos / 3600;
            restosegundos = segundos % 3600;
            minutos = restosegundos / 60;
            restosegundos = restosegundos % 60;
            Console.WriteLine("{0} segundos son: {1} horas {2} minutos {3} segundos", segundos, horas, minutos, restosegundos);
            Console.ReadKey();
        }
        static public void Primeros15NumSeriePell()
        {
            int[] pell = new int[0];
            int numeroElementos = 15;

            for (int i = 0; i < numeroElementos; i++)
            {
                Array.Resize(ref pell, i + 1);
                if (i != 0 && i != 1)
                {
                    pell[i] = pell[i - 2] + (pell[i - 1] * 2);
                }
                else
                {
                    if (i == 0)
                    {
                        pell[i] = 1;
                    }
                    else
                    {
                        pell[i] = 2;
                    }
                }
            }
            Console.WriteLine("{0} primeros números de la suseción de Pell:\n", numeroElementos);
            for (int i = 0; i < pell.Length; i++)
            {
                Console.Write("{0} ", pell[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static public void NumeroArmstrong()
        {
            int Numero;
            Console.WriteLine("Introduzca un número para saber si es un número Armstrong: ");
            Numero = PedirNumero();

            string numeroString = Convert.ToString(Numero);
            double sumatorioAmstrong = 0;

            for (int i = 0; i < numeroString.Length; i++)
            {
                int digito = numeroString[i] - '0';
                sumatorioAmstrong += Math.Pow(digito, numeroString.Length);
            }

            if (sumatorioAmstrong == Numero)
            {
                Console.WriteLine("{0} es un número Armstrong!", Numero);

            }
            else
            {
                Console.WriteLine("{0} NO es un número Armstrong...", Numero);
            }

            Console.WriteLine("Resultado del sumatorio se sus digitos a la potencia de su longitud: {0}", sumatorioAmstrong);
            Console.ReadKey();
        }
        static public bool ComprobarNumeroDistintos()
        {
            int Numero;
            Console.WriteLine("Introduzca un número para saber si todos los digitos son diferentes o hay repetidos: ");
            Numero = PedirNumero();
            string numeroString = Convert.ToString(Numero);
            string comparador = "";
            for (int i = 0; i < numeroString.Length; i++)
            {
                if (i != 0)
                {
                    for (int j = 0; j < comparador.Length; j++)
                    {
                        if (numeroString[i] == comparador[j])
                        {
                            Console.WriteLine("Se han repetido dígitos.");
                            Console.ReadKey();
                            return false;
                        }
                    }
                    comparador += numeroString[i];
                }
                else
                {
                    comparador += numeroString[i];
                }

            }
            Console.WriteLine("No se han repetido digitos");
            Console.ReadKey();
            return true;

        }
        static public int PedirSegundos()
        {
            int segundos = 0;
            while (!Int32.TryParse(Console.ReadLine(), out segundos) || !(segundos > 0))
            {
                Console.WriteLine("Error! Debe introducir un número entero referente a las horas (mayor que 0). Inténtelo de nuevo");
            }
            return segundos;
        }
        static public int PedirNumero()
        {
            int numero = 0;
            while (!Int32.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Error! Debe introducir un número entero");
            }
            return numero;
        }
    }
}
