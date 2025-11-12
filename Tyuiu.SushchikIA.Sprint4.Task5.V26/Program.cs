using Tyuiu.SushchikIA.Sprint4.Task5.V26.Lib;
    
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Сущик И.А. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Операции сравнения в C#                                           *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #26                                                             *");
Console.WriteLine("* Выполнил: Сущик Игорь Александрович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int[,] myIntArray = new int[5, 5];
Console.WriteLine(ds.Calculate(myIntArray));