using KnowCheck9_10;
using System.Text.Json;

Console.WriteLine("How many Zebras are you profiling?");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Zebra>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var zebra = new Zebra();

    Console.WriteLine("Where does the animal live?");
    zebra.Biome = Console.ReadLine();

    Console.WriteLine("What does the animal eat?");
    zebra.Diet = Console.ReadLine();

    Console.WriteLine("How would you describe the animals personality?");
    zebra.Personality = Console.ReadLine();

    Console.WriteLine(JsonSerializer.Serialize(zebra));

    recordList.Add(zebra);
}

// Print out the list of records using Console.WriteLine()
