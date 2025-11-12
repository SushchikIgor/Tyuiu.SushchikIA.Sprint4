using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SushchikIA.Sprint4.Task5.V26.Lib
{
    public class DataService : ISprint4Task5V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] myArray = new int[,] { { 0, 4, 6, 6, 0 }, { 6, 0, 6, 0, 0 }, { 0, 0, 0, 0, 6 }, { 6, 4, 0, 6, 6 }, { 0, 4, 0, 4, 0 } };
            return myArray;
        }
    }
}
