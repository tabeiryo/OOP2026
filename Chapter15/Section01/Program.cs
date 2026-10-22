using System.Runtime.InteropServices.Marshalling;

List<IGreetingBase> list = [
    new GreetingMorning(),
    new GreetingAfternoon(),
    new GreetingEvening(),
    ];

foreach (var obj in list)
{
    string msg = obj.GetMessage();
    Console.WriteLine(msg);
}

interface IGreetingBase { 
 string GetMessage() => "";
}

class GreetingMorning : IGreetingBase
{
    string GetMessage() => "おはよう";
}

class GreetingAfternoon : IGreetingBase
{
    string GetMessage() => "こんにちは";
}

class GreetingEvening : IGreetingBase    
{
    string GetMessage() => "こんばんは";
}
