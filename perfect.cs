using System; 
using System.Linq; 

namespace Project_perfect_Number 
{ 
public static class Program 
{ 
public static bool Isperfect(int number) 
{ 
int sum = 0; 
for (int i = 1; i < number; i++) 
{ 
if (number % i == 0) sum = sum + i; 
} 
if (sum == number) return true; 
return false; 
} 
static void Main(string[] args) 
{ 
int x, y; 
Console.Write("Please entre the first number"); 
x = int.Parse(Console.ReadLine()); 
Console.Write("Please entre the second number"); 
y = int.Parse(Console.ReadLine()); 
for (int i = x; i <= y; i++) 
{ 
if (Isperfect(i)) Console.Write("{0},", i); 
} 
Console.ReadLine(); 
} 
} 
}
