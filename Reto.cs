using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasCSharp
{
    public class Reto
    {
        public void Resolverfizzconfor(int limite)
        {
            for (int i = 1; i <= limite; i++)
            {
                int multiplodetres = i % 3;
                int multiplodecinco = i % 5;

                if (multiplodetres == 0 && multiplodecinco == 0)
                    Console.WriteLine("FizzBuzz");
                else if (multiplodetres == 0)
                    Console.WriteLine("Fizz");
                else if (multiplodecinco == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }

        public void Resolverfizzconforeach(int limite)
        {
            List<int> Arraydel1al100 = new List<int>();
            for (int i = 1; i <= limite; i++)
            {
                Arraydel1al100.Add(i);
            }

            foreach (int numero in Arraydel1al100)
            {
                int multiplodetres = numero % 3;
                int multiplodecinco = numero % 5;

                if (multiplodetres == 0 && multiplodecinco == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (multiplodetres == 0)
                    Console.WriteLine("Fizz");
                else if (multiplodecinco == 0)
                    Console.WriteLine("Buzz");
                else Console.WriteLine(numero);
            }
        }
    }
}
