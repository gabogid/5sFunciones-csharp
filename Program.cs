using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5sFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //int a = 1;
                //int b = 2;

                Show(); // *1er

                Sum(1, 2); // *2da

                int m = Mul(300, 5); //*3er
                Console.WriteLine(m); //*3er
                Console.ReadLine(); //*3er

            }
            static int Mul(int num1, int num2) //Función: Tercera forma
            {
                return num1 * num2;
            }
            //Console.WriteLine(-------------------------);

            static void Sum(int num1, int num2) //Función: Segunda forma 
            {
                int num3 = num1 + num2;
                Console.WriteLine(num3);
                Console.ReadLine();
            }
            //Console.WriteLine(-------------------------);

        static void Show() //Función: Primera forma 
            {
                Console.WriteLine("Hola, soy un texto q se imprime desde una función");
                Console.ReadLine();
            }
            //Console.WriteLine(-------------------------);
    }
}