using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MailChimp.Net
{
    public static class HttpContentExtensions
    {
        public static async Task<T> ReadAsAsync<T>(this HttpContent content) {
            var data = await content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
