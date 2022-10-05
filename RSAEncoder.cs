namespace Crypt_2
{
    static public class RSAEncoder
    {
        static public List<long> Encode(List<char> plainText, long n, long exp)
        {
            return plainText.Select(c => (long)Power.FastModPow(c, exp, n)).ToList();
            //return (long)Power.FastModPow(plainText, exp, n);
        }
    }
}
