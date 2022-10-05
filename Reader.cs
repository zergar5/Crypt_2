using System.Text;

namespace Crypt_2
{
    static public class Reader
    {
        static public List<long> ConsoleRead()
        {
            return Console.ReadLine().
                Replace("(", "").Replace(")", "").Replace(",", "")
                .Split(" ").Select(x => Convert.ToInt64(x)).ToList();
        }

        static public List<char> PlainTextRead(string textFile)
        {
            List<char> text = new List<char>();
            using (var fileStream = new FileStream(textFile, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    text = reader.ReadToEnd().ToList();
                }
            }
            return text;
        }

        static public bool IsPrime(long number)
        {
            if (number < 2) return false;
            for (long i = 2; i * i <= number; i++)
                if (number % i == 0) return false;
            return true;
        }
    }
}
