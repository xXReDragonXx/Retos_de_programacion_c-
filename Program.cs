using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticasCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            


            // Opcion que gusta correr
            Console.WriteLine("Seleccione Numero");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                    /* RETO EL FAMOSO FIZZ BUZZ
                    * Escribe un programa que muestre por consola (con un print) los
                    * números de 1 a 100 (ambos incluidos y con un salto de línea entre
                    * cada impresión), sustituyendo los siguientes:
                    * - Múltiplos de 3 por la palabra "fizz".
                    * - Múltiplos de 5 por la palabra "buzz".
                    * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
                    */
                case 1:
                    Reto FizzBuzz = new Reto();
                    FizzBuzz.Resolverfizzconfor(20);
                    break;
                case 2:
                    Reto FizzBuzzA = new Reto();
                    FizzBuzzA.Resolverfizzconforeach(20);
                    break;
                    /* ES UN ANAGRAMA?
                    * Escribe una función que reciba dos palabras (String) y retorne
                    * verdadero o falso (Bool) según sean o no anagramas.
                    * - Un Anagrama consiste en formar una palabra reordenando TODAS
                    *   las letras de otra palabra inicial.
                    * - NO hace falta comprobar que ambas palabras existan.
                    * - Dos palabras exactamente iguales no son anagrama.
                    */
                case 69:
                    Reto EsAnagrama = new Reto();
                    EsAnagrama.Anagramaono("vaaaa", "vaaaa");
                    break;
            }
            
            
            

            
           
        }
    }
}
