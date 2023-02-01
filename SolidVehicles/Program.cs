using SolidVehicles.Aircraft;
using SolidVehicles.Cars;
using SolidVehicles.WaterCraft;
// See https://aka.ms/new-console-template for more information

static void Main()
{
    // Build a collection of all vehicles that fly
    List<IAircraft> allAircraft = new List<IAircraft> { new Boeing737(), new MilleniumFalcon() };

    // With a single `foreach`, have each vehicle Fly()
    foreach (IAircraft aircraft in allAircraft)
    {
        aircraft.Fly();
    }


    // Build a collection of all vehicles that operate on roads
    List<ICar> allCars = new List<ICar> { new NissanLeaf(), new Porsche() };
    // With a single `foreach`, have each road vehicle Drive()

    foreach (ICar car in allCars)
    {
        car.Drive();
    }


    // Build a collection of all vehicles that operate on water
    // With a single `foreach`, have each water vehicle Drive()
    List<IWatercraft> allWaterCraft = new List<IWatercraft> { new AboatTime(), new BoatyMcBoatFace() };

    foreach (IWatercraft watercraft in allWaterCraft)
    {
        watercraft.Sail();
    }

}
