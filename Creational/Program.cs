using Creational.Builder;
using Creational.Factory;
using Creational.Factory.Abstract;
using Creational.Prototype;
using Creational.Singleton;

Console.WriteLine("----------Sinleton start----------");
Guitar guitar_1 = Guitar.GetInstance("Cort 250");
Console.WriteLine(guitar_1.Name);
Guitar guitar_2 = Guitar.GetInstance("Fender 110");
Console.WriteLine(guitar_2.Name);
Console.WriteLine("----------Sinleton end------------");

Console.WriteLine("\n");

Console.WriteLine("----------Builder start----------");
GuitarComponentsBuilder builder = new();
GuitarComponents guitarComponents = builder
    .SetStrings(true)
    .SetGuitarCase(false)
    .SetStrap(true)
    .SetPick(true)
    .SetCapo(true)
    .SetStand(true)
    .Build();
Console.WriteLine(guitarComponents);
Console.WriteLine("----------Builder end------------");

Console.WriteLine("\n");

Console.WriteLine("----------Prototype start----------");
Piano piano_1 = new("yamaha 180");
Console.WriteLine(piano_1);
Piano piano_2 = (Piano)piano_1.DoClone();
Console.WriteLine(piano_2);
Console.WriteLine("----------Prototype end------------");

Console.WriteLine("\n");

Console.WriteLine("----------Factory start----------");
InstrumentFactory instrumentFactory = new();
IMusicalInstrument instrument_1 = instrumentFactory.CreateInstrument("saxophone");
instrument_1.Play();
IMusicalInstrument instrument_2 = instrumentFactory.CreateInstrument("accordion");
instrument_2.Play();
IMusicalInstrument instrument_3 = instrumentFactory.CreateInstrument("drums");
instrument_3.Play();
Console.WriteLine("----------Factory end------------");

Console.WriteLine("\n");

Console.WriteLine("----------Abstract factory start----------");
MusicalStoreFactory musicalStoreFactory = new();
InstrumentTypeFactory instrumentTypeFactory_1 = musicalStoreFactory.GetInstrumentTypeFactory("brass");
IMusicalInstrument instrument_4 = instrumentTypeFactory_1.GetInstrument("trumpet");
instrument_4.Play();
IMusicalInstrument instrument_5 = instrumentTypeFactory_1.GetInstrument("trombone");
instrument_5.Play();

InstrumentTypeFactory instrumentTypeFactory_2 = musicalStoreFactory.GetInstrumentTypeFactory("stringed");
IMusicalInstrument instrument_6 = instrumentTypeFactory_2.GetInstrument("electric guitar");
instrument_6.Play();
IMusicalInstrument instrument_7 = instrumentTypeFactory_2.GetInstrument("bass guitar");
instrument_7.Play();
Console.WriteLine("----------Abstract factory end------------");
