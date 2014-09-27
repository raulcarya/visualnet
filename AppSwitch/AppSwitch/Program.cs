using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            /*ingreasr un numero entre uno y cinco en castellanos
             *luego mostrar en formato numerico
             * un valor fuera de rango mostrar mensaje
             * indicando tal situacion*/

            string numero,num;
            
            Console.WriteLine("Programa que pasa de caracter a numero");
            Console.WriteLine("escriba un numero de 1 a 5 en letras");
            numero=Console.ReadLine();
            num=numero.ToUpper();
            Console.WriteLine(num);
           
           
            
            
            switch(num)

                {

                case"UNO":

                    Console.WriteLine("1");
                    break;

                case"DOS":

                    Console.WriteLine("2");
                    break;


                case"TRES":

                    Console.WriteLine("3");
                    break;


                case"CUATRO":

                    Console.WriteLine("4");
                    break;

                case"CINCO":

                    Console.WriteLine("5");
                    break;


                default:

                    Console.WriteLine("numero fuera de rango");
            break;

                


        }

        Console.ReadKey();
                    }

    }

}
