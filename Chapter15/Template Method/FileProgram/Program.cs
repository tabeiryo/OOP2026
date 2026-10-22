using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Text.RegularExpressions;
using TextFileProcessor;


string path = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\Section04\Program.cs";
TextProcessor.Run<FileProgramProcessor>(path);

public  class FileProgramProcessor : TextProcessor
{
    private int _count = 0;
    
    protected override void Initialize(string fname) =>
        _count = 0;

    protected override void Execute(string line) {
        if (line.Contains("static")) {
        _count++;
        }

        
    }
       
        

    protected override void Terminate() =>
        Console.WriteLine("{0} 個", _count);
}