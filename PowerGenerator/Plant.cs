using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace PowerGenerator
{
    public class Plant : IPlant
    {
        public Plant(string name)
        {
            PlantName = name;
            Generators = new List<Generator>();
        }

        [NotNull] public string PlantName { get; set; }

        [NotNull] public List<Generator> Generators { get; set; }

        public void AddGenerator(params Generator[] newgenerators)
        {
            Generators.AddRange(newgenerators);
        }

        public bool LightUpHouse(decimal housePower)
        {
            if (Generators.Sum(g => g.Capacity) >= housePower)
            {
                Console.WriteLine($"Powering house with {housePower} requirement");
                return true;

            }
                Console.WriteLine($"Not sufficient power");
                return false;
        }

        public IGrouping<int, Generator>[] AllGenerators()
        {
            var x = from generator in Generators
                group generator by generator.Type
                into genCategory
                select genCategory;

            return x.ToArray();
        }

        public void ShowInfo()
        {
            foreach (var generator in Generators) Console.WriteLine(generator);
        }
    }
}