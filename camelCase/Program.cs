using System;
using System.Text;

namespace camelCase
{
    class Program
    {
        public static string MakePascalCase(string[] input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i].ToLower();
                StringBuilder modWord = new StringBuilder();
                bool nextCap = true;

                for (int j = 0; j < word.Length; j++)
                {


                    if (word[j] == ' ') nextCap = true;

                    else if (word[j] >= 'a' && word[j] <= 'z' && nextCap == true)
                    {
                        modWord.Append(Char.ToUpper(word[j]));
                        nextCap = false;
                    }
                    else if (word[j] >= 'a' && word[j] <= 'z') modWord.Append(word[j]);
                }

                result.Append(modWord.ToString());
                modWord.Clear();
            }

            return result.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MakePascalCase(new string[] { "hello 2-C!ody", "hOW", "aRe", "YOU"}));
        }
    }
}
