using System.Security.Cryptography;

namespace Fucntions
{
    class Dice
    {
        public int D6()
        {
            return RandomNumberGenerator.GetInt32(6);
        }

        public int D100()
        {
            return RandomNumberGenerator.GetInt32(100);
        }
    }

    class RandomString
    {
        public String Random(int lenthWanted)
        {
            String alpabet = "abcdefghijklmnopqrs";
            String result = "";
            for (int i = 0; i < lenthWanted; i++)
            {
                result += alpabet[RandomNumberGenerator.GetInt32(alpabet.Length)];
            }
            return result;
        }
    }
}