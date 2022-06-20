namespace Strategy.Compress;

// Step 3. Creating context

public class CompressionContext
{
    private ICompression _compression;

    public CompressionContext(ICompression compression)
    {
        _compression = compression;
    }

    public void SetStrategy(ICompression compression)
    {
        _compression = compression;
    }

    public void CreateArchive(string filename)
    {
        _compression.CompressFolder(filename);
    }
    
}