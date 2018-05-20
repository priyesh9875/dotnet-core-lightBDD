using LightBDD.Framework;
using LightBDD.Framework.Scenarios.Basic;
using LightBDD.Framework.Scenarios.Extended;
using LightBDD.NUnit3;

namespace PowerGenerator.Tests
{
	[Label("FEAT-1")]
	[FeatureDescription(
@"In order to make money
As a CEO
I want to setup new powerplant")]
	public partial class SetUpPowerPlantFeature
	{
		[Label("SCENARIO-1")]
		[Scenario]
		public void SetUpScenario1()
		{
			Runner.RunScenario(
                _ => CleanUp(),
				_ => Given_Name("Plant 1"),
				_ => SetUpPlant(),
				_ => PlantIsReady());
		}

		[Label("SCENARIO-2")]
		[Scenario]
		public void SetUpScenario2()
		{
			Runner.RunScenario(
			    _ => CleanUp(),
                _ => Given_Name("Plant 2"),
//				_ => SetUpPlant(),
				_ => PlantIsReady());
		}
	}
}