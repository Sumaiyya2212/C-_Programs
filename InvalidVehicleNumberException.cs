using System;
public class InvalidVehicleNumberException : Exception
{
public InvalidVehicleNumberException(string message) :
base(message)
{
}
}
public class Program
{
public static void Main()
{
try
{
Console.WriteLine(&quot;Enter Vehicle Registration Number:
&quot;);
string vehicleNumber = Console.ReadLine();

Console.WriteLine(&quot;Vehicle Registration Number
is:&quot;+vehicleNumber);
if (IsValidVehicleNumber(vehicleNumber))
{
Console.WriteLine(&quot;Valid Vehicle Registration
number&quot;);
}
else
{
throw new InvalidVehicleNumberException(&quot;Invalid
Vehicle Registration number&quot;);
}
}
catch (InvalidVehicleNumberException ex)
{
Console.WriteLine(ex.Message);
}
finally
{

Console.WriteLine(&quot;Drive safe and make safe India&quot;);
}
}
public static bool IsValidVehicleNumber(string
vehicleNumber)
{
bool isValid = true;

if (vehicleNumber.Length != 10)
{
isValid = false;
}
else
{
string stateCode = vehicleNumber.Substring(0, 2);
string districtCode = vehicleNumber.Substring(2, 2);
string serialNumber = vehicleNumber.Substring(4, 1);
string number = vehicleNumber.Substring(5);

if (!char.IsLetter(stateCode[0]) ||
!char.IsLetter(stateCode[1]))
{
isValid = false;
}
else if (!char.IsDigit(districtCode[0]) ||
!char.IsDigit(districtCode[1]))
{
isValid = false;
}
else if (!char.IsLetter(serialNumber[0]) &amp;&amp;
serialNumber.Length != 1 || !char.IsLetterOrDigit(number[0])
|| !char.IsDigit(number[1]) || !char.IsDigit(number[2]) ||
!char.IsDigit(number[3]))
{
isValid = false;
}
}
return isValid;
}

}
