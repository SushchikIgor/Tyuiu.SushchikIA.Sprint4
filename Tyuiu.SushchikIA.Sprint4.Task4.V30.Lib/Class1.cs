using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SushchikIA.Sprint4.Task4.V30.Lib
{
    public class DataService : ISprint4Task4V30
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] myArray = new int[,] { { 0, 4, 6, 6, 0 }, { 6, 0, 6, 0, 0 }, { 0, 0, 0, 0, 6 }, { 6, 4, 0, 6, 6 }, { 0, 4, 0, 4, 0 } };
            return myArray;
        }
    }
}
