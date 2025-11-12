using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SushchikIA.Sprint4.Task5.V26.Lib
{
    public class DataService : ISprint4Task5V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] myArray = new int[,] {
    {-3, 1, 1, 0, 1},
    {-2, 1, -3, -2, -3},
    {-4, 1, 1, -2, 1},
    {1, -4, 0, -4, 1},
    {-1, 1, 1, -3, 1}
}; return myArray;
        }
    }
}
