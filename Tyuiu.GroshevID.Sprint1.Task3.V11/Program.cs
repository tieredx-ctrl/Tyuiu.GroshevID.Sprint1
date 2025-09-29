using Tyuiu.GroshevID.Sprint1.Task3.V11.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Грошев И. Д. | РППб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил: Грошев Илья Дмитриевич | РППб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x1, y1, x2, y2, x3, y3;

        Console.WriteLine("Введите значение x1: ");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение x3: ");
        x3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y3: ");
        y3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Площадь треугольника: " + ds.TriangleArea(x1, y1, x2, y2, x3, y3) + " кв.см");

        Console.ReadLine();
    }
}