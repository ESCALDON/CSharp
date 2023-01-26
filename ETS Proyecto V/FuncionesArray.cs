using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Proyecto_V
{
    class Arrays
    {
        private int TamanioArray { get; set; }
        private double[]? NumerosArray { get; set; }
        public Arrays()
        {
            
        }
        public int GetTamanioArray()
        {
            return TamanioArray;
        }
        public double[] GetNumerosArray()
        {
            return NumerosArray;
        }
        public void SetTamanioArray()
        {
            TamanioArray = PedirTamanioArray();
        }
        public void SetNumerosArray()
        {
            NumerosArray = PedirNumerosArray();
        }
        public int PedirTamanioArray()  
        {
            Console.Clear();
            Boolean Completo = false;
            int TamanioArray;
            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca el tamaño del array: ");
                if (int.TryParse(Console.ReadLine(), out TamanioArray)) 
                {
                    if (TamanioArray > 2)
                    {
                        Completo = true;
                    } 
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR: El tamaño minimo es 2. \nIntentelo de nuevo");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("ERROR: Debe introducir un número. \nIntentelo de nuevo");
                    Console.ReadKey();
                }
            } while (!Completo);

            return (TamanioArray);
        }
        public double[] PedirNumerosArray()
        {
            double[] PedirNumerosArray = new double[TamanioArray];
            Boolean Completo = false;

            for (int ContadorPeticion = 0; ContadorPeticion < PedirNumerosArray.Length; ContadorPeticion++)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Introduzca el número en la posición {0}:", ContadorPeticion + 1);
                    if (double.TryParse(Console.ReadLine(), out PedirNumerosArray[ContadorPeticion]))
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
            return (PedirNumerosArray);
        }
        public void MenuArray()
        {
            ConsoleKeyInfo option;
            do
            {
                ShowMenu();
                option = Console.ReadKey(true);
                switch (option.KeyChar)
                {
                    case '1': GetTamanioArray(); GetNumerosArray() ; CalcularMaximo(NumerosArray); break;
                    case '2': GetTamanioArray(); GetNumerosArray(); CalcularMinimo(NumerosArray); break;
                    case '3': GetTamanioArray(); GetNumerosArray(); CalcularLaMediana(NumerosArray); break;
                    case '4': GetTamanioArray(); GetNumerosArray(); CalcularLaMedia(NumerosArray); break;
                    case '5': GetTamanioArray(); GetNumerosArray(); OrdenarDeMenorAMayor(NumerosArray); break;
                    case '6': GetTamanioArray(); GetNumerosArray(); DesviacionTipica(NumerosArray); break;
                    case '7': BinarizarEnBaseAUnNumero(); break;
                }
            } while (!option.KeyChar.Equals('8'));

        }
        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-           Menu de Arrays              -");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- Elige entre siguientes opciones       -");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- 1. Calcular máximo.                   -");
            Console.WriteLine("- 2. Calcular mínimo.                   -");
            Console.WriteLine("- 3. Calcular la mediana                -");
            Console.WriteLine("- 4. Calcular la media.                 -");
            Console.WriteLine("- 5. Ordenar de menor a mayor.          -");
            Console.WriteLine("- 6. Desviación típica.                 -");
            Console.WriteLine("- 7. Binarizar en base a un número      -");
            Console.WriteLine("- 8. Salir                              -");
            Console.WriteLine("-----------------------------------------");
        }
        static public void CalcularMaximo(double[] Numeros)
        {
            double numeroMaximo = 0;

            for (int i = 0; i < Numeros.Length; i++)
            {
                if (i == 0)
                {
                    numeroMaximo = Numeros[i];
                }
                else
                {
                    if (numeroMaximo < Numeros[i])
                    {
                        numeroMaximo = Numeros[i];
                    }
                }
            }
            MostrarVector(Numeros);
            Console.WriteLine("El número máximo es: {0}", numeroMaximo);
            Console.ReadKey();
        }
        static public void CalcularMinimo(double[] Numeros)
        {
            double numeroMinimo = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (i == 0)
                {
                    numeroMinimo = Numeros[i];
                }
                else
                {
                    if (numeroMinimo > Numeros[i])
                    {
                        numeroMinimo = Numeros[i];
                    }
                }
            }
            MostrarVector(Numeros);
            Console.WriteLine("El número mínimo es: {0}", numeroMinimo);
            Console.ReadKey();
        }
        static public void CalcularLaMediana(double[] Numeros)
        {
            double mediana = 0;

            if (Numeros.Length % 2 == 0)
            {
                double valorIntermedioMenor;
                double valorIntermedioMayor;
                valorIntermedioMenor = Numeros[(Numeros.Length / 2) - 1];
                valorIntermedioMayor = Numeros[(Numeros.Length / 2)];
                mediana = valorIntermedioMenor + valorIntermedioMayor / 2;
            }
            else
            {
                double valorIntermedio;
                double mitadVector = Numeros.Length / 2;
                mediana = Numeros[Convert.ToInt32(Math.Truncate(mitadVector) + 1)];
            }
            Console.ReadKey();
        }
        static public void CalcularLaMedia(double[] Numeros)
        {
            double sumatorioTotal = 0;
            double media = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                sumatorioTotal += Numeros[i];
            }
            media = (sumatorioTotal / Numeros.Length);
            MostrarVector(Numeros);
            Console.WriteLine("Sumatorio Total de todos los elementos: {0}", sumatorioTotal);
            Console.WriteLine("Media: {0}", media);
            Console.ReadKey();
        }
        static public void OrdenarDeMenorAMayor(double[] Numeros)
        {
            Array.Sort(Numeros);
            MostrarVector(Numeros);
            Console.ReadKey();
        }
        static public void DesviacionTipica(double[] Numeros)
        {
            double sumatorioTotal = 0;
            double media = 0;
            double sumatorioDesviacion = 0;
            double divisionDesviacion = 0;
            double desviacionTipica = 0;

            for (int i = 0; i < Numeros.Length; i++)
            {
                sumatorioTotal += Numeros[i];
            }
            media = sumatorioTotal / Numeros.Length;


            //Desviación típica
            for (int i = 0; i < Numeros.Length; i++)
            {
                sumatorioDesviacion += Math.Pow(Numeros[i] - media, Convert.ToDouble(2));
            }

            divisionDesviacion = sumatorioDesviacion / Numeros.Length;
            desviacionTipica = Math.Sqrt(divisionDesviacion);

            Console.WriteLine("Deviación típica de los valores introducidos: {0}", desviacionTipica);
            Console.ReadKey();

        }
        static public void BinarizarEnBaseAUnNumero()
        {
            int numero = PedirNumeroEntero();
            string numeroBinario = Convert.ToString(numero, 2);
            Console.WriteLine("{0} en binario {1}", numero, numeroBinario);
            Console.ReadKey();
        }
        static public void MostrarVector(double[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("{0} ", vector[i]);
            }
            Console.WriteLine("");
            Console.ReadKey();
        }

        static public int PedirNumeroEntero()
        {
            int numero = 0;
            Console.WriteLine("Introduzca un número entero:");
            while (!Int32.TryParse(Console.ReadLine(), out numero) || !(numero > 0))
            {
                Console.WriteLine("Error! Debe introducir un número entero. Inténtelo de nuevo");
            }
            return numero;
        }
    }
}
