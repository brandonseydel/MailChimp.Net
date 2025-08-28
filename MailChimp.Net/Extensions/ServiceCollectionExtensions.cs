
#if NET_CORE
using MailChimp.Net.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MailChimp.Net;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMailChimpClient(this IServiceCollection services, string apiKey
        )
    {
        services.AddScoped<IMailChimpManager, MailChimpManager>();

        services.Configure<MailChimpOptions>(options => {
            options.ApiKey = apiKey;
        });

        return services;
    }

}
#endif
