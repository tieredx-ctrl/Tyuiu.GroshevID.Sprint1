using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GroshevID.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            string[] words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                {
                    words[i] = words[i].Substring(0, words[i].Length - 1);
                }
                else
                {
                    words[i] = "";
                }
            }

            string res = string.Join(" ", Array.FindAll(words, w => !string.IsNullOrEmpty(w)));
            return res;
        }
    }
}
