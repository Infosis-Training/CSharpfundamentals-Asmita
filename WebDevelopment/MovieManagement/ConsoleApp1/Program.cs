
//Threading:Thread
//TPL: Task Parallel Library, Task


//Parallel programming

using System.Diagnostics;

int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

void Compute(int n)
{
    //takes some time
    Console.WriteLine($"Working for {n}");
    Thread.Sleep(1000);
}
Stopwatch sp = new();
sp.Start();
foreach(var n in numbers)
{
    Compute(n);
}
Console.WriteLine($"Sequential: It took {sp.ElapsedMilliseconds} ms");

sp.Restart();
Parallel.ForEach(numbers, n => Compute(n));
Console.WriteLine($"Parallel: It took {sp.ElapsedMilliseconds} ms");

//asynchronous programming
HttpClient client = new HttpClient();
var googleContent = await client.GetStreamAsync("www.google.com");
var googleContent = await client.GetStreamAsync("www.google.com");

