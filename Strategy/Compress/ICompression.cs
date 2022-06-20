namespace Strategy.Compress;

// Step 1. Creating Abstract Strategy

public interface ICompression
{
    void CompressFolder(string filename);
}