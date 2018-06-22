using System;
using System.Linq;
using System.Reflection;
using Extensions;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            var exit = 'n';

            while (exit.IsNotIn("yY"))
            {
                Console.Write("Choose problem number: ");
                var choice = Console.ReadLine();
                Console.Clear();

                var assembly = Assembly.GetEntryAssembly();
                var all = assembly.DefinedTypes.Where(x => x.ImplementedInterfaces.Contains(typeof(IProblem)));

                var typeInfo = all.FirstOrDefault(x => x.Name == $"Problem{choice}");

                if (typeInfo == default) Console.WriteLine("Solution not found");
                else
                {
                    var instance = assembly.CreateInstance(typeInfo.FullName) as IProblem;
                    Console.WriteLine($"Problem {choice}");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Title:");
                    Console.WriteLine(instance.Title);
                    Console.WriteLine();
                    Console.WriteLine("Description:");
                    Console.WriteLine(instance.Description);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine($"Solution: {instance.GetSolution()}");
                }

                Console.WriteLine();
                Console.Write("Exit? (y/n): ");
                exit = Console.ReadKey().KeyChar;
                Console.Clear();
            }
        }
    }
}
