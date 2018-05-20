using System.Collections.Generic;
using System.Linq;

namespace PowerGenerator
{
    internal interface IPlant
    {
        string PlantName { get; set; }
        List<Generator> Generators { get; set; }
        void AddGenerator(params Generator[] newgenerators);
        bool LightUpHouse(decimal housePower);
        IGrouping<int, Generator>[] AllGenerators();
    }
}