namespace Strategy.Compress;

// Step 2. Creating concrete Strategy

public class ZipCompression : ICompression
{
    public void CompressFolder(string filename)
    {
        Console.WriteLine($"Folder is compressed using Zip approach: {filename}.zip file is created");
    }
}