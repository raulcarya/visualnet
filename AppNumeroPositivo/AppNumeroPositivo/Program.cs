using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumeroPositivo
{
    class Program
    {
        static void Main(string[] args)
        {


            string numero;
            int num;
            Console.WriteLine("Programa numero positivo");
            Console.WriteLine("Digite un numero de 1 a 99:");
            numero=Console.ReadLine();
            num = int.Parse(numero);
            if(numero.Length<=2 && num>0)


                {

                    Console.WriteLine("el numero es positivo");
                if(numero.Length==2)

                    {

                        Console.WriteLine("el numero tiene dos digitos");
                    }

                else
                    {

                        Console.WriteLine("el numero tiene un digito");
                    }


                }
            else
            {

                Console.WriteLine("el numero esta fuera de rango");

                            }
            Console.ReadKey();




        }
    }
}
