using System;
using System.Threading;
public class Program
{

public static void Main()
{
Thread t1 = new Thread(new ThreadStart(PrintTable5));
Thread t2 = new Thread(new ThreadStart(PrintTable12));
t1.Start();
t2.Start();
t1.Join();
t2.Join();
}
public static void PrintTable5()
{
for (int i = 1; i &lt;= 10; i++)
{
Console.WriteLine(&quot;5 x {0} = {1}&quot;, i, 5 * i);
Thread.Sleep(1000); // Wait for 1 second before printing the
next line
}
}
public static void PrintTable12()
{

for (int i = 1; i &lt;= 10; i++)
{
Console.WriteLine(&quot;12 x {0} = {1}&quot;, i, 12 * i);
Thread.Sleep(1000); // Wait for 1 second before printing the
next line
}
}
}
