//Задача 2
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string message)
{
    System.Console.Write(message);              // Подсказка
    return Convert.ToInt32(Console.ReadLine()); // Преобразование введенной пользователем строки в число
}
int x1 = ReadInt("Введите x1 => ");
int x2 = ReadInt("Введите x2 => ");
int y1 = ReadInt("Введите y1 => ");
int y2 = ReadInt("Введите y2 => ");
int q1 = ReadInt("Введите q1 => ");
int q2 = ReadInt("Введите q2 => ");
int rangex = x1 - x2;
int rangey = y1 - y2;
int rangeq = q1 - q2;
double range = Math.Sqrt(rangex*rangex + rangey*rangey + rangeq*rangeq);
System.Console.WriteLine($"Расстояние между координатами равно {range}");