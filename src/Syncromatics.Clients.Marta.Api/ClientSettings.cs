namespace Syncromatics.Clients.Marta.Api
{
    public class ClientSettings
    {
        public string ServerRootUrl { get; }
        public string ApiKey { get; }

        public ClientSettings(string serverRootUrl, string apiKey)
        {
            ServerRootUrl = serverRootUrl;
            ApiKey = apiKey;
        }
    }
}