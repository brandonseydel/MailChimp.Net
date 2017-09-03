namespace MailChimp.NetCore.Extensions
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public static class HttpExtensions
    {
        public static async Task<T> ReadAsAsync<T>(this HttpContent content) where T : class
        {
            string data = await content.ReadAsStringAsync().ConfigureAwait(false);

            var response = JsonConvert.DeserializeObject<T>(data);

            return response;
        }
    }
}