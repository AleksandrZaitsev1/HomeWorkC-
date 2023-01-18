/*int max = 0;
int min = 0;
int  a, b;

Console.Write(" Введите Имя   ");
string? username = Console.ReadLine();
Console.Write("Привет!");
Console.WriteLine(username);

Console.WriteLine("Введите число a");
 a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
 b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
   max = a;
   min = b;
}
else 
{
    min = a;
    max = b;
}
Console.WriteLine("max = " + max + "и" + " min = " + min  );*/

/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/


int  a , b , c;

Console.Write(" Введите Имя   ");
string? username = Console.ReadLine();
Console.Write("Привет!");
Console.WriteLine(username);

Console.WriteLine("Введите число a");
 a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
 b = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число c");
 c = Convert.ToInt32(Console.ReadLine());

 int max = a;

 if (b > max)
 {
    max = b;
 }  
 if ( c > max)
 {
    max = c;
 }
 Console.WriteLine("max = " + max);