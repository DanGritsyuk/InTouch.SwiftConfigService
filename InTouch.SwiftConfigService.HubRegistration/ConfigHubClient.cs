using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Logging;

namespace InTouch.SwiftConfigService.HubRegistration
{
    public class ConfigHubClient
    {
        private readonly ILogger<ConfigHubClient> _logger;

        HubConnection? connection;

        public ConfigHubClient(ILogger<ConfigHubClient> logger)
        {
            _logger = logger;
            connection = null;
        }

        public async Task Connect()
        {
            try
            {
                this.connection = new HubConnectionBuilder()
                    .WithUrl(@"https://localhost:7260/config")
                    .WithAutomaticReconnect()
                    .Build();

                _logger.LogInformation("Successful connect to config hub.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error connect to config hub.");
            }


        }
    }
}