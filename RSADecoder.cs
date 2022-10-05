namespace Crypt_2
{
    public class RSADecoder
    {
        static public List<char> Decode(List<long> cipherText, long n, long d)
        {
            return cipherText.Select(c => (char)(long)Power.FastModPow(c, d, n)).ToList();
        }
    }
}
