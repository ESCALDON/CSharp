using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Proyecto_V
{
    class Array
    {
        private int TamanioArray { get; set; }
        private double[] NumerosArray { get; set; }
        public Array()
        {
            Console.Clear();
            this.TamanioArray = PedirTamanioArray();
            this.NumerosArray = PedirNumerosArray();
        }
        public int GetTamanioArray()
        {
            return (this.TamanioArray);
        }
        public double[] GetNumerosArray()
        {
            return this.NumerosArray;
        }
        public void SetTamanioArray()
        {
            this.TamanioArray = PedirTamanioArray();
        }  
        public void SetNumerosArray()
        {
            this.NumerosArray = PedirNumerosArray();
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
                this.ShowMenu();
                option = Console.ReadKey(true);
                switch (option.KeyChar)
                {
                    case '1': CalcularMaximo(NumerosArray); break;
                    case '2': CalcularMinimo(); break;
                    case '3': CalcularLaMediana(); break;
                    case '4': CalcularLaMedia(); break;
                    case '5': OrdenarDeMenorAMayor(); break;
                    case '6': DesviacionTipica(); break;
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
        public void CalcularMaximo(double[] Numeros)
        {

        }
        public void CalcularMinimo()
        {

        }
        public void CalcularLaMediana()
        {

        }
        public void CalcularLaMedia()
        {

        }
        public void OrdenarDeMenorAMayor()
        {

        }
        public void DesviacionTipica()
        {

        }
        public void BinarizarEnBaseAUnNumero()
        {

        }
    }
}
