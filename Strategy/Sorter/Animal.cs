using System.Collections;
using static System.String;

namespace Strategy.Sorter;

public class Animal : IComparable
{
    public double Height { get; set; }
    public double Weight { get; set; }
    public string Name { get; set; }
    
    public Animal(string name, double height, double weight)
    {
        Name = name;
        Height = height;
        Weight = weight;
    }

    public override string ToString()
    {
         return $"{Name}, height is {Height} & weight is {Weight}";
    }

    public int CompareTo(object? obj)
    {
        var another = (Animal)obj!;
        return CompareOrdinal(Name, another.Name);
    }

    public static IComparer SortHeight()
    {
        return new AnimalHeightComparer();
    }
    
    public static IComparer SortWeight()
    {
        return new AnimalWeightComparer();
    }

    private class AnimalHeightComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            var animal1 = (Animal)x!;
            var animal2 = (Animal)y!;

            return animal1.Height > animal2.Height ? 1 : -1;
        }
    }
    
    private class AnimalWeightComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            var animal1 = (Animal)x!;
            var animal2 = (Animal)y!;

            return animal1.Weight > animal2.Weight ? 1 : -1;
        }
    }
}