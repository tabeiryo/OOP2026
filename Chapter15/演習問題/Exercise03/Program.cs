using Exercise03;

var service = new LineCounter();
var processor = new TextFileProcessor(service);
Console.WriteLine("パスの入力");
processor.Run(Console.ReadLine());