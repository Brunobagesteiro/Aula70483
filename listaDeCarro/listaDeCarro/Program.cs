using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> minhaListaDeCarro = new List<string>
            {
                "combi",
                "deurey",
                "fusca",
                "belina",
                "chevet",


            };

            minhaListaDeCarro.ForEach(x => Console.WriteLine(x));

            Console.ReadKey(true);

        }
    }
}
