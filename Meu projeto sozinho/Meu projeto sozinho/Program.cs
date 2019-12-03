using System;
using System.Collections.Generic;

namespace Meu_projeto_sozinho
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string>
                minhaLista = new List<string>
            {
                   
                "Bruno",
                "juca",
                "junica",
                "Ariosto",
                "roberval"
            };

            minhaLista.ForEach(x => Console.WriteLine(x));
            
           
                


            Console.ReadKey(true);
        }
    }
}
