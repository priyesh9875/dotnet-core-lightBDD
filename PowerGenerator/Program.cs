using System;
using System.Linq;

namespace PowerGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to new Power plant.");


            var plantCss = @"
                #plant {
                    border: 1px solid red;
                }

                #plant > p {
                        display: flex;
                }
            ";
            var powerPlant = new Plant("Plant 1");
            foreach (var i in Enumerable.Range(0, 10))
                powerPlant.AddGenerator(new Generator(i, string.Format($"Generator {i}")));


            powerPlant.LightUpHouse(15);


            var generators = powerPlant.AllGenerators();
            foreach (var generatorGroup in generators)
            {
                Console.WriteLine($"=====Type {generatorGroup.Key} ======");
                foreach (var generator in generatorGroup) Console.WriteLine(generator);
            }

            Console.WriteLine(1 / 3);
        }
    }
}