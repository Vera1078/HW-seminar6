// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

static void MyTask41()
{
    Console.WriteLine("Введите числа через пробел: \t");
    int[] userArray = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
           int count = 0;

        for (int i = 0; i<userArray.Length; i++)
        {
            if (userArray[i] > 0) count++;
        }
    System.Console.WriteLine($"Количество чисел больше 0 = \t{count}");
    
}
MyTask41();
System.Console.WriteLine();
System.Console.WriteLine();

// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



void MyTask43()
{   

Console.Write("Введите значение k1: \t");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b1: \t");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: \t");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: \t");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

System.Console.WriteLine($"Точка пересечения прямых: ({x:f2}; {y:f2})");
}
MyTask43();
