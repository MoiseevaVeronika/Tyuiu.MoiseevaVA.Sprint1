using System.Text;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MoiseevaVA.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            // Разбиваем текст на слова по пробелам
            string[] words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                // Очищаем слово от знаков препинания в начале и конце, чтобы правильно посчитать длину
                string cleanWord = word.Trim(new char[] { '.', ',', '!', '?', ';', ':', '-', '(', ')', '"', '\'' });

                // Сохраняем знаки препинания отдельно (если они были)
                int startIndex = word.IndexOf(cleanWord, StringComparison.Ordinal);
                string prefix = startIndex > 0 ? word.Substring(0, startIndex) : "";
                string suffix = startIndex >= 0 ? word.Substring(startIndex + cleanWord.Length) : "";

                // Если длина слова нечетная и оно не пустое
                if (cleanWord.Length > 0 && cleanWord.Length % 2 != 0)
                {
                    int middleIndex = cleanWord.Length / 2;
                    // Удаляем средний символ
                    string newWord = cleanWord.Remove(middleIndex, 1);
                    result.Append(prefix + newWord + suffix + " ");
                }
                else
                {
                    // Если длина четная, оставляем без изменений
                    result.Append(word + " ");
                }
            }

            return result.ToString().Trim();
        }
    }
}
