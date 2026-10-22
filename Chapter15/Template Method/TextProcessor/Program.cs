

namespace TextFileProcessor;

public abstract class TextProcessor {
    public static void Run<T>(string fileName) where T : TextProcessor, new()
    {
        var self = new T();
        self.Process(fileName);
    }

    private void Process(string fileName)
    {
        Initialize(fileName);
        var lines = File.ReadLines(fileName);
        foreach (var line in lines)
        {
            Execute(line);
        }
        Terminate();
    }

    private void Initialize(string fname)
    {
    }

    private void Execute(string line)
    {
    }

    private void Terminate()
    {
    }
}