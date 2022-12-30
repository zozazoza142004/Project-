using System; 
using System.Linq; 

namespace Tiffg 
{ 
public static class Program 
{ 
public static void Main() 
{ 
int i,Number,sum,Minimum,Maximum; 
Console.WriteLine("Please entre the Minimum and Maximum values"); 
Minimum = int.Parse(Console.ReadLine()); 
Maximum = int.Parse(Console.ReadLine()); 
Number = Minimum; 
Console.WriteLine("prime numbers between Minimum and Maximum"); 
while(Number <= Maximum) 
{ 
sum=0; 
i=2; 
while(i <= Number/2) 
{ 
if(Number%i == 0) 
{ 
sum++; 
break; 
} 
i++; 
} 
if(sum == 0 && Number !=1) 
{ 
Console.WriteLine("Number"+Number); 
} 
Number++; 
} 

} 
} 
}
