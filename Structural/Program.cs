using Structural.Adapter;
using Structural.Bridge;
using Structural.Composite;
using Structural.Decorator;
using Structural.Facade;
using Structural.Flyweight;
using Structural.Proxy;

Console.WriteLine("----------Adapter start----------");
Truck truck = new();
DieselEngine dieselEngine = new();
truck.StartEngine(dieselEngine);
ElectricEngine electricEngine = new();
truck.StartEngine(new ElectricEngineAdapter(electricEngine));
Console.WriteLine("----------Adapter end------------");

Console.WriteLine("----------Decorator start----------");
Car car_1 = new LuxuryCar("Maybach gls 600");
Console.WriteLine(car_1.GetPrice());
car_1 = new NavigationSystemDecorator(car_1);
car_1 = new HeatedSeatsDecorator(car_1);
Console.WriteLine(car_1.Name);
Console.WriteLine(car_1.GetPrice());

Console.WriteLine();

Car car_2 = new LowPricedCar("Kia Forte");
Console.WriteLine(car_2.GetPrice());
car_2 = new HeatedSeatsDecorator(car_2);
Console.WriteLine(car_2.Name);
Console.WriteLine(car_2.GetPrice());
Console.WriteLine("----------Decorator end------------");

Console.WriteLine();

Console.WriteLine("----------Bridge start------------");
Bicyclist bicyclist_1 = new AdvancedBicyclist(new MountainBicycle());
bicyclist_1.Cycling();
bicyclist_1.Compete();

Console.WriteLine();

bicyclist_1.Bicycle = new ElectricBicycle();
bicyclist_1.Cycling();
bicyclist_1.Compete();
Console.WriteLine("----------Bridge end--------------");

Console.WriteLine();

Console.WriteLine("----------Composite start--------------");
CarComponent seat = new Seat("Leather seat");
CarComponent floor = new Floor("Carpeted floor");
CarComponent audio = new Audio("Harman Kardon");

CarSalon salon = new CarSalon("Salon for BMW X6");
salon.AddComponent(seat);
salon.AddComponent(floor);
salon.AddComponent(audio);
salon.Display();
Console.WriteLine("----------Composite end----------------");

Console.WriteLine();

Console.WriteLine("----------Facade start----------------");
VehicleDesign design = new();
VehicleFactory factory = new();
VehicleSafety safety = new();

VehicleManufacturingFacade facade = new VehicleManufacturingFacade(design, factory, safety);

ProductionManager manager = new();
manager.ManageManufacturing(facade);
Console.WriteLine("----------Facade end------------------");

Console.WriteLine();

Console.WriteLine("----------Flywieght start------------------");
AirTransportFactory airTransportFactory = new AirTransportFactory();

AirTransport plane1 = airTransportFactory.GetAirTransport("Boeing 747", "Plane");
AirTransport helicopter1 = airTransportFactory.GetAirTransport("Apache AH-64", "Helicopter");
AirTransport plane2 = airTransportFactory.GetAirTransport("Airbus A380", "Plane");
AirTransport helicopter2 = airTransportFactory.GetAirTransport("Black Hawk", "Helicopter");

plane1.Fly(40.7128, -74.0060);
helicopter1.Fly(34.0522, -118.2437);
plane2.Fly(51.5074, -0.1278);
helicopter2.Fly(37.7749, -122.4194);
Console.WriteLine("----------Flywieght end------------------");

Console.WriteLine();

Console.WriteLine("----------Proxy start------------------");
IWorker worker = new WorkerProxy("Bob");
worker.LogIn();
worker.LogOut();
Console.WriteLine("----------Proxy end------------------");
