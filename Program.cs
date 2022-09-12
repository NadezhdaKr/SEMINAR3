// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine();
Console.Write("Введите число: ");
string? number = Console.ReadLine();
void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Число: {number} - палиндром.");
  }
  else Console.WriteLine($"Число: {number} - не палиндром.");
}
if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine();



//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine();
int a1 = Coordinate("a", "D");
int b1 = Coordinate("b", "D");
int c1 = Coordinate("c", "D");
int a2 = Coordinate("a", "V");
int b2 = Coordinate("b", "V");
int c2 = Coordinate("c", "V");
int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double a1, double a2, 
                double b1, double b2, 
                double c1, double c2){
  return Math.Sqrt(Math.Pow((a2-a1), 2) + 
                   Math.Pow((b2-b1), 2) + 
                   Math.Pow((c2-c1), 2));
}

double segmentLength =  Math.Round (Decision(a1, a2, b1, b2, c1, c2), 2 );

Console.WriteLine($"Растояние {segmentLength}");


