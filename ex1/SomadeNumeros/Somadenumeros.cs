using Syste;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomadeNumeros
{
    class Program 
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            resultado = (a + b);

            Console.WriteLine("Aqui você pode somar dois números!");
            Console.WriteLine("Digite o primeiro número: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Esse é o {resultado}");
        }
    }
}