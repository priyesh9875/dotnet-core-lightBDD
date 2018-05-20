using System;
using LightBDD.NUnit3;
using NUnit.Framework;

[assembly: LightBddScope]
namespace PowerGenerator.Tests
{
	public partial class SetUpPowerPlantFeature: FeatureFixture
	{

	    public void CleanUp()
	    {
	        plantName = null;
	        powerPlant = null;
	    }
	    private string plantName;

	    private PowerGenerator.Plant powerPlant;

	    private void Given_Name(string plant)
	    {
	        plantName = plant;

	    }

	    private void PlantIsReady()
	    {
	        Assert.IsNotNull(powerPlant);
	    }

	    private void SetUpPlant()
	    {
	        powerPlant = new Plant(plantName);
        }
    }
}