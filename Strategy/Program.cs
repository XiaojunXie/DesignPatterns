// See https://aka.ms/new-console-template for more information

using Strategy.Compress;
using Strategy.Sorter;

#region Zip & Rar Compression

// Step 4. Client

// compress can use .rar and .zip 2 different algs(solutions)

var ctx = new CompressionContext(new ZipCompression());
ctx.CreateArchive("Should Zip Strategy Pattern");

ctx.SetStrategy(new RarCompression());
ctx.CreateArchive("Should Rar Strategy Pattern");

// output:
// Folder is compressed using Zip approach: Should Zip Strategy Pattern.zip file is created
// Folder is compressed using Rar approach: Should Rar Strategy Pattern.rar file is created


#endregion

#region AnimalSorter

var animals = new[]
{
    new Animal("Lucky", 55, 10),
    new Animal("Marvel", 50, 14),
    new Animal("Timo", 30, 6)
};

Array.Sort(animals);
Console.WriteLine("======== By default, should sort by name ================");
foreach (var a in animals)
{
    Console.WriteLine(a.ToString());
}


Array.Sort(animals, Animal.SortHeight());
Console.WriteLine("======== Should sort by height ================");
foreach (var a in animals)
{
    Console.WriteLine(a.ToString());
}

Array.Sort(animals, Animal.SortWeight());
Console.WriteLine("======== Should sort by weight ================");
foreach (var a in animals)
{
    Console.WriteLine(a.ToString());
}

#endregion



