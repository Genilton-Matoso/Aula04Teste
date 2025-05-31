using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota");
            float nota01 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            float nota02 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota");
            float nota03 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota");
            float nota04 = float.Parse(Console.ReadLine());

            float notaFinal = (nota01 + nota02 + nota03 + nota04) / 4;


            if (notaFinal >= 8 && notaFinal <= 10)

            {
                Console.WriteLine("Aprovado!");

            }

            else if (notaFinal >= 5 && notaFinal <= 7)
            {

                Console.WriteLine("Passou raspando");

            }

            else

            {
                Console.WriteLine("Reprovado");
            }


        }
    }
}
