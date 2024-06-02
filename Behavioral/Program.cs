using Behavioral.ChainOfResponsibility;
using Behavioral.Command;
using Behavioral.Iterator;
using Behavioral.Mediator;
using Behavioral.Momento;
using Behavioral.Observer;
using Behavioral.State;
using Behavioral.Strategy;
using Behavioral.TemplateMethod;
using Behavioral.Visitor;

Console.WriteLine("----------Command start----------");
Truck truck = new Truck();
ICommand accelerateCommand = new AccelerateCommand(truck, 100);
ICommand brakeCommand = new BrakeCommand(truck, 50);

TruckDriver truckDriver = new TruckDriver();
truckDriver.ExecuteCommand(accelerateCommand);
truckDriver.ExecuteCommand(brakeCommand);
Console.WriteLine("----------Command end------------");

Console.WriteLine();

Console.WriteLine("----------Iterator start----------");
CarCollection carCollection = new CarCollection();
Client client = new Client();
client.SeeAllCars(carCollection);
Console.WriteLine("----------Iterator end------------");

Console.WriteLine();

Console.WriteLine("----------Strategy start----------");
Bus bus = new Bus(new EconomyDrivingStrategy());
bus.Drive();

bus.SetDrivingStrategy(new ComfortDrivingStrategy());
bus.Drive();

bus.SetDrivingStrategy(new SportDrivingStrategy());
bus.Drive();
Console.WriteLine("----------Strategy end------------");

Console.WriteLine();

Console.WriteLine("----------Chain Of Responsibility start----------");
CarComponent engine = new EngineComponent();
CarComponent transmission = new TransmissionComponent();
CarComponent brakes = new BrakesComponent();

engine.SetNextComponent(transmission);
transmission.SetNextComponent(brakes);

Console.WriteLine("Starting the car:");
engine.ProcessRequest("start");

Console.WriteLine("\nShifting gears:");
engine.ProcessRequest("shift");

Console.WriteLine("\nApplying brakes:");
engine.ProcessRequest("brake"); 
Console.WriteLine("----------Chain Of Responsibility end------------");

Console.WriteLine();

Console.WriteLine("----------Momento start----------");
Train train = new Train("Running", 100);

TrainMemento initialMemento = train.CreateMemento();

Console.WriteLine("Initial Status:");
train.DisplayStatus();

train.EngineStatus = "Stopped";
train.Speed = 0;

Console.WriteLine("\nModified Status:");
train.DisplayStatus();

train.SetMemento(initialMemento);

Console.WriteLine("\nRestored Status:");
train.DisplayStatus();
Console.WriteLine("----------Momento end------------");

Console.WriteLine();

Console.WriteLine("----------Observer start----------");
Plane plane = new Plane();

var engineObserver = new EngineOverheatObserver();
var fuelObserver = new LowFuelObserver();

plane.Attach(engineObserver);
plane.Attach(fuelObserver);

plane.EngineOverheat();
plane.LowFuel();
Console.WriteLine("----------Observer end------------");

Console.WriteLine();

Console.WriteLine("----------State start----------");
Bicycle bicycle = new Bicycle();

bicycle.Pedal();    
bicycle.Brake();    
bicycle.Start();    
bicycle.Pedal();   
bicycle.Brake();    
bicycle.Pedal();
Console.WriteLine("----------State end------------");

Console.WriteLine();

Console.WriteLine("----------Template Method start----------");
Console.WriteLine("Manufacturing process for a car:");
VehicleManufacturingProcess carProcess = new CarManufacturingProcess();
carProcess.ManufacturingProcess();

Console.WriteLine("\nManufacturing process for a truck:");
VehicleManufacturingProcess truckProcess = new TruckManufacturingProcess();
truckProcess.ManufacturingProcess();

Console.WriteLine("\nManufacturing process for a motorcycle:");
VehicleManufacturingProcess motorcycleProcess = new MotorcycleManufacturingProcess();
motorcycleProcess.ManufacturingProcess();
Console.WriteLine("----------Template Method end------------");

Console.WriteLine();

Console.WriteLine("----------Mediator start----------");
MotorcycleMediator mediator = new MotorcycleMediator();
MotorcycleEngineComponent motoEngine = new MotorcycleEngineComponent(mediator);
MotorcycleGearboxComponent motoGearbox = new MotorcycleGearboxComponent(mediator);
MotorcycleBrakesComponent motoBrakes = new MotorcycleBrakesComponent(mediator);

mediator.RegisterEngine(motoEngine);
mediator.RegisterGearbox(motoGearbox);
mediator.RegisterBrakes(motoBrakes);

engine.ProcessRequest("start");
Console.WriteLine("----------Mediator end------------");

Console.WriteLine();

Console.WriteLine("----------Visitor start----------");
BoatEngine boatEngine = new BoatEngine();
Propeller propeller = new Propeller();
SteeringWheel steeringWheel = new SteeringWheel();

Boat boat = new Boat();
boat.AddComponent(boatEngine);
boat.AddComponent(propeller);
boat.AddComponent(steeringWheel);

ServiceVisitor serviceVisitor = new ServiceVisitor();
boat.Accept(serviceVisitor);
Console.WriteLine("----------Visitor end----------");
