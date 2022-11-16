//  Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//

//ПОЛУЧЕНИЕ ДАННЫХ ДЛЯ ОБРАБОТКИ
Console.WriteLine("Введите первую координату первой прямой b1");
double b1 = Convert.ToInt32((Console.ReadLine()));
Console.WriteLine("Введите вторую координату первой прямой b2");
double b2 = Convert.ToInt32((Console.ReadLine()));
Console.WriteLine("Введите первую координату второй прямой k1");
double k1 = Convert.ToInt32((Console.ReadLine()));
Console.WriteLine("Введите вторую координату второй прямой k2");
double k2 = Convert.ToInt32((Console.ReadLine()));
//проверка пересекаются ли прямые.
if ((k1 == k2) || (b1 == b2))
{
    Console.WriteLine("Прямые не пересекаются.");
    return;
}
else Console.Write("Прямые пересекаются в точке: ");

//МЕТОДЫ
//метод поиска Х.
double SearchX(double xb1, double xb2, double xk1, double xk2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
//метод поиска У.
double SearchY(double yb1, double yk1, double x)
{
    double y = yk1 * x + yb1;
    return y;
}
//ВЫВОД РЕЗУЛЬТАТА
double x = SearchX(b1, b2, k1, k2);
double y = SearchY(b1, k1, x);

Console.WriteLine($"X = {x}; Y = {y}");