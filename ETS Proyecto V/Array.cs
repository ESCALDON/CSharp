using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Proyecto_V
{
    class Array
    {
        static private int TamanioArray { get; set; }
        static private double[]? NumerosArray { get; set; }
        public Array()
        {
            Console.Clear();
            TamanioArray = PedirTamanioArray();
            NumerosArray = PedirNumerosArray();
        }
        static public int GetTamanioArray()
        {
            return TamanioArray;
        }
        static public double[] GetNumerosArray()
        {
            return NumerosArray;
        }
        static public void SetTamanioArray()
        {
            TamanioArray = PedirTamanioArray();
        }
        static public void SetNumerosArray()
        {
            NumerosArray = PedirNumerosArray();
        }
        static public int PedirTamanioArray()  
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
        static public double[] PedirNumerosArray()
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
        static public void MenuArray()
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
                    case '7': GetTamanioArray(); GetNumerosArray(); BinarizarEnBaseAUnNumero(NumerosArray); break;
                }
            } while (!option.KeyChar.Equals('8'));

        }
        static private void ShowMenu()
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

        }
        static public void CalcularMinimo(double[] Numeros)
        {

        }
        static public void CalcularLaMediana(double[] Numeros)
        {

        }
        static public void CalcularLaMedia(double[] Numeros)
        {

        }
        static public void OrdenarDeMenorAMayor(double[] Numeros)
        {

        }
        static public void DesviacionTipica(double[] Numeros)
        {

        }
        static public void BinarizarEnBaseAUnNumero(double[] Numeros)
        {

        }
    }
}
