
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valore_Max_di_Sequenza{
    class Program{
        static void Main(string[] args){
            /* Stampare il massimo di una sequenza di interi forniti in input terminanti con 0 */
            string value;
            bool success;
            int max = 0, a = 0, b = 0;
            Console.WriteLine("Inserisci dei numeri e ti dirò quello più grande. Inserisci 0 quando vuoi finire la sequenza.");
            do
            {
                b = a;
                Console.Write("Inserisci un numero: ");
                value = Console.ReadLine();
                success = Int32.TryParse(value, out a);
                if (success)
                {
                    if (a > b && a > max) max = a;
                }
                else Console.WriteLine("Numero non inserito correttamente");
            } while (a != 0 || success == false);
            Console.WriteLine("Il valore massimo tra quelli che hai inserito è: " + max);
            Console.WriteLine("Premi un tasto per terminare il programma");
            Console.ReadKey();
        }
    }
}
