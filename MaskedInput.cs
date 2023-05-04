using System;
public class ISE1
{
public static void Main()
{
string input = &quot;4556364607935616&quot;;
string masked = Maskit(input);
Console.WriteLine(masked);
}
public static string Maskit(string inputString)
{
if (string.IsNullOrEmpty(inputString))
{
return &quot;&quot;;

}
int length = inputString.Length;
int maskLength = Math.Max(length - 3, 0);
string maskedString = new string(&#39;*&#39;, maskLength);
if (length &lt;= 3)
{
return maskedString + inputString;
}
return maskedString + inputString.Substring(length - 3);
}
}
