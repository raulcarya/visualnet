using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSwitchnumletra
{
    class Program
    {
        static void Main(string[] args)
        {

            string numero, num;

            Console.WriteLine("Programa que pasa de nummero a caracter");
            Console.WriteLine("escriba un numero de 1 a 5 ");
            numero = Console.ReadLine();
            num = numero.ToLower();
             



            switch (num)
            {

                case "1":

                    Console.WriteLine("UNO");
                    break;

                case "2":

                    Console.WriteLine("DOS");
                    break;


                case "3":

                    Console.WriteLine("TRES");
                    break;


                case "4":

                    Console.WriteLine("CUATRO");
                    break;

                case "5":

                    Console.WriteLine("CINCO");
                    break;


                default:

                    Console.WriteLine("numero fuera de rango");
                    break;




            }

            Console.ReadKey();


        }
    }
}
