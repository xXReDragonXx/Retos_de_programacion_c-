using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* RETO EL FAMOSO FIZZ BUZZ
            * Escribe un programa que muestre por consola (con un print) los
            * números de 1 a 100 (ambos incluidos y con un salto de línea entre
            * cada impresión), sustituyendo los siguientes:
            * - Múltiplos de 3 por la palabra "fizz".
            * - Múltiplos de 5 por la palabra "buzz".
            * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
*/
            Reto FizzBuzz = new Reto();
            FizzBuzz.Resolverfizzconfor(20);
            Reto FizzBuzzA = new Reto();
            FizzBuzzA.Resolverfizzconforeach(20);
            Console.ReadLine();
        }
    }
}
