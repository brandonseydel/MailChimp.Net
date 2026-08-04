using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;

namespace MailChimp.Net;

public static class HttpContentExtensions
{
    public static async Task<T> ReadAsAsync<T>(this HttpContent content) {
        var data = await content.ReadAsStringAsync();

        return MailChimpSerializer.Deserialize<T>(data);
    }
}
