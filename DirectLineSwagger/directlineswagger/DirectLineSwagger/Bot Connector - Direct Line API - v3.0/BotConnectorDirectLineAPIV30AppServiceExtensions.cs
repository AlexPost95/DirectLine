using System;
using System.Net.Http;
using Microsoft.Azure.AppService;

namespace ConsoleApplication2
{
    public static class BotConnectorDirectLineAPIV30AppServiceExtensions
    {
        public static BotConnectorDirectLineAPIV30 CreateBotConnectorDirectLineAPIV30(this IAppServiceClient client)
        {
            return new BotConnectorDirectLineAPIV30(client.CreateHandler());
        }

        public static BotConnectorDirectLineAPIV30 CreateBotConnectorDirectLineAPIV30(this IAppServiceClient client, params DelegatingHandler[] handlers)
        {
            return new BotConnectorDirectLineAPIV30(client.CreateHandler(handlers));
        }

        public static BotConnectorDirectLineAPIV30 CreateBotConnectorDirectLineAPIV30(this IAppServiceClient client, Uri uri, params DelegatingHandler[] handlers)
        {
            return new BotConnectorDirectLineAPIV30(uri, client.CreateHandler(handlers));
        }

        public static BotConnectorDirectLineAPIV30 CreateBotConnectorDirectLineAPIV30(this IAppServiceClient client, HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
        {
            return new BotConnectorDirectLineAPIV30(rootHandler, client.CreateHandler(handlers));
        }
    }
}
