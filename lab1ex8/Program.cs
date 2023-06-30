using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Program care interschimba valoarea a doua variabile intregi introduce de la tastatura. */

            int x;
            int y;

            Console.WriteLine("Introduceti prima variabila:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti a doua variabila:");
            y=int.Parse(Console.ReadLine());


            Console.WriteLine();


            Console.Write("Inainte de schimbarea variabilelor:" + "x = " + x + ";" + " y = " + y+ ";");
            x = x * y;      
            y = x / y;     
            x = x / y;    
            Console.Write("\n"+ "Dupa schimbarea variabilelor:" +"      "+ "x = " + x + ";" + " y = " + y+ ".");
           

            Console.WriteLine();
        }
    }
}