using System;
public class Student
{
private string regNo;
private string name;
private DateTime dob;
private double m1;
private double m2;
private double m3;
public string RegNo
{
get { return regNo; }
set { regNo = value; }
}
public string Name
{
get { return name; }
set { name = value; }
}
public DateTime DOB

{
get { return dob; }
set { dob = value; }
}
public double M1
{
get { return m1; }
set { m1 = value; }
}
public double M2
{
get { return m2; }
set { m2 = value; }
}
public double M3
{
get { return m3; }
set { m3 = value; }
}
public int Age
{
get { return DateTime.Now.Year - dob.Year; }
}

public double AverageMarks

{
get { return (m1 + m2 + m3) / 3; }
}
public Student(string regNo, string name, DateTime dob, double m1, double
m2, double m3)
{
this.regNo = regNo;
this.name = name;
this.dob = dob;
this.m1 = m1;
this.m2 = m2;
this.m3 = m3;
}
public void PrintDetails()
{
Console.WriteLine(&quot;{0,-10} {1,-20} {2,-10} {3,-10} {4,-10} {5,-10} {6,-
10}&quot;,
regNo, name, dob.ToShortDateString(), Age, m1, m2, m3);
}
}
public class ISE1
{
public static void Main()
{
Student[] students = new Student[3];

students[0] = new Student(&quot;B001&quot;, &quot;Vaishnavi&quot;, new DateTime(1999, 3,
15), 70, 80, 90);
students[1] = new Student(&quot;B002&quot;, &quot;Sumaiyya&quot;, new DateTime(1999, 5,
20), 75, 70, 80);
students[2] = new Student(&quot;B003&quot;, &quot;Prerna&quot;, new DateTime(2000, 7, 25),
75, 70, 80);
Console.WriteLine(&quot;{0,-10} {1,-20} {2,-10} {3,-10} {4,-10} {5,-10} {6,-
10}&quot;,
&quot;Reg No&quot;, &quot;Name&quot;, &quot;DOB&quot;, &quot;Age&quot;, &quot;Mark 1&quot;, &quot;Mark 2&quot;, &quot;Mark 3&quot;);
Console.WriteLine(new string(&#39;-&#39;, 80));
foreach (Student student in students)
{
student.PrintDetails();
}
Console.WriteLine(new string(&#39;-&#39;, 80));
Console.WriteLine(&quot;{0,-10} {1,-20} {2,-10} {3,-10} {4,-10} {5,-10} {6,-
10}&quot;,
&quot;&quot;, &quot;Average Marks&quot;, &quot;&quot;, &quot;&quot;, students[0].AverageMarks,
students[1].AverageMarks, students[2].AverageMarks);
}
}
