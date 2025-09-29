using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GroshevID.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            double reversed = 0;

            while (number > 0)
            {
                int currentDigit = (int)reversed % 10;
                reversed = reversed * 10 + currentDigit;
                number = (long)(reversed / 10);
            }
            number = reversed;

            return number;
        }
    }
}
