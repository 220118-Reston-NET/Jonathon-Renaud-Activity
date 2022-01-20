// See https://aka.ms/new-console-template for more information
using CollectionFunction;
using ConversionFunction;

Console.WriteLine("Hello, World!");

Collection collect = new Collection();
collect.CollectionMain();

Conversion.ConversionMain();
Conversion._num=10;
Conversion conv1 = new Conversion();
Conversion conv2 = new Conversion();

Console.WriteLine(conv1.GiveMeNumber());
Console.WriteLine(conv2.GiveMeNumber());