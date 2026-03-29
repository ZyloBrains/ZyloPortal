using ZyloApp.Web.Helpers;

namespace ZyloApp.Web.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBrowserTimeProvider(this IServiceCollection services)
        => services.AddTransient<TimeProvider, BrowserTimeProvider>();
}