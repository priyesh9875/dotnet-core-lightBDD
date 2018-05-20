using System;
using JetBrains.Annotations;

namespace PowerGenerator
{
    public sealed class Generator : IGenerator
    {
        private static int _autoId;

        [NotNull] private static readonly Random Random;

        static Generator()
        {
            Random = new Random();
        }


        public Generator(int capacity, string name)
        {
            Capacity = capacity;
            Name = name;
            Type = Random.Next(1, 4);
            Id = ++_autoId;
        }

        public int Type { get; set; }

        public int Capacity { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }


        public override string ToString()
        {
            return string.Format("Generator {0} with capacity {1} MWh", Name, Capacity);
        }
    }
}