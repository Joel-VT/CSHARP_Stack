Vehicle Vehicle1 = new Vehicle("Honda Accord", 5, "White", true, 120);

Vehicle Vehicle2 = new Vehicle("Mountain Bike", "Black");

Vehicle Vehicle3 = new Vehicle("Rollerblades", "White");

Vehicle Vehicle4 = new Vehicle("Boing 747", 200, "White", true, 400);

List<Vehicle> allVehicles = new List<Vehicle>();
allVehicles.Add(Vehicle1);
allVehicles.Add(Vehicle2);
allVehicles.Add(Vehicle3);
allVehicles.Add(Vehicle4);

foreach (Vehicle OneVehicle in allVehicles)
{
    OneVehicle.ShowInfo();
}

Vehicle4.Travel(200);
Vehicle4.ShowInfo();