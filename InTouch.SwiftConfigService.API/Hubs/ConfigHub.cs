using Microsoft.AspNetCore.SignalR;

namespace InTouch.SwiftConfigService.API.Hubs
{
    public class ConfigHub : Hub
    {
        private readonly ILogger<ConfigHub> _logger;

        public ConfigHub(ILogger<ConfigHub> logger)
        {
            _logger = logger;
        }

        public override async Task OnConnectedAsync()
        {
            _logger.LogInformation("Successful access");
            await base.OnConnectedAsync();
        }
    }
}
