using Microsoft.Extensions.DependencyInjection;

namespace InTouch.SwiftConfigService.HubRegistration
{
    public static class ConfigHubClientDIExtension
    {
        public static IServiceCollection RegSwiftConfigService(this IServiceCollection services)
        {
            services.AddSingleton<ConfigHubClient>();
            var provider = services.BuildServiceProvider();
            var service = provider.GetService<ConfigHubClient>();
            service!.Connect().GetAwaiter().GetResult();
            return services;
        }
    }
}