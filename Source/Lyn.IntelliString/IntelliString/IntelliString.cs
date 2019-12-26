using System;
using System.Text;
using System.Threading;

namespace Lyn.IntelliString
{
    public enum Algorithm
    {
        SHA256,
    }

    public static class IntelliString
    {
        private static long _InternalValue = 1;

        public static string HashString(string value, Algorithm algorithm = Algorithm.SHA256)
        {
            var hash = System.Security.Cryptography.SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(value));
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }

            return result.ToString();
        }

        public static string Hash(this string value, Algorithm algorithm = Algorithm.SHA256)
        {
            return HashString(value, algorithm);
        }

        public static string Hash(this string value, string salt, Algorithm algorithm = Algorithm.SHA256)
        {
            return HashString(value + salt, algorithm);
        }

        public static string RandomHash(this string value, Algorithm algorithm = Algorithm.SHA256)
        {
            var newValue = Interlocked.Increment(ref _InternalValue);

            return HashString(value + newValue.ToString() + DateTime.Now.ToString(), algorithm);
        }
    }
}
