using System.Text;

namespace Crypt_2
{
    static public class Writer
    {
        static public void Write(string outfile, List<char> text)
        {
            using (var streamWriter = new FileStream(outfile, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (var writer = new StreamWriter(streamWriter, Encoding.UTF8))
                {
                    foreach (var symbol in text)
                    {
                        writer.Write(symbol);
                    }
                }
            }
        }

        static public void Write(string outfile, List<long> text)
        {
            using (var streamWriter = new FileStream(outfile, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (var writer = new StreamWriter(streamWriter, Encoding.UTF8))
                {
                    foreach (var symbol in text)
                    {
                        writer.Write(symbol);
                        writer.Write(" ");
                    }
                }
            }
        }
    }
}
