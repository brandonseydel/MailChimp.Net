using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        public static T Deserialize<T>(this Stream stream)
        {
            using (var reader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var jsonSerializer = new JsonSerializer();
                return jsonSerializer.Deserialize<T>(jsonReader);
            }
        }
        public static async Task EnsureSuccessMailChimpAsync(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                throw (await response.Content.ReadAsStreamAsync()).Deserialize<MailChimpException>();
            }
        }
    }
}