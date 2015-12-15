using System.Security.Cryptography;
using System.Text;

namespace MailChimp.Net.Core
{
    public static class Helper
    {
        public static string GetMd5Hash(this MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();
            foreach (var t in data)
            {
                sBuilder.Append(t.ToString("x2"));
            }
            return sBuilder.ToString();
        }

    }
}
