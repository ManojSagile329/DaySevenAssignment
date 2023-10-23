// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using DaySevenAssignment;

Console.WriteLine("Enter Product Name ");
string name = Console.ReadLine();
Console.WriteLine("Enter Price");
float p = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter Number of Units");
int u = Convert.ToInt32(Console.ReadLine());

Bill1 b = new Bill1() { prodname=name,price=p,units=u};
b.Calculate();
