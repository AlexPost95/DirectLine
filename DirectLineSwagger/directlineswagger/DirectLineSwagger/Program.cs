using System;
using ConsoleApplication2.Models;
using Microsoft.Rest;
using Newtonsoft.Json;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            BotConnectorDirectLineAPIV30 client = new BotConnectorDirectLineAPIV30(new TokenCredentials("6oeQzwIVOfA.cwA.FwU.nWo5sDNAiySIxf2kV6TB7Z2-AoJefMdATMesNOpkHzc"));
            var conversationClient = new Conversations(client);
            var result = conversationClient.StartConversationWithOperationResponseAsync().Result;
            var waterMark = "";
            while (true)
            {
                var textToSend = Console.ReadLine();
                var r = conversationClient.PostActivityWithOperationResponseAsync(result.Body.ConversationId,
                    new Activity() { Type = "message", From = new ChannelAccount() { ID = "Alex" }, Text = textToSend }).Result;

                var activities = conversationClient.GetActivitiesWithOperationResponseAsync(result.Body.ConversationId, waterMark).Result;
                waterMark = activities.Body.Watermark;

                foreach (var activity in activities.Body.Activities)
                {
                    Console.WriteLine($"{activity.From.ID}:{activity.Text}");

                    if (activity.Attachments != null)
                    {
                        for (int i = 0; i < activity.Attachments.Count; i++)
                        {
                            if (activity.Attachments[i].ContentType == "application/vnd.microsoft.card.adaptive")
                            {
                                Console.WriteLine(activity.Attachments[i].Content.ToString());
                            }
                            else if (activity.Attachments[i].ContentType == "application/vnd.microsoft.card.hero")
                            {
                                var heroCard = JsonConvert.DeserializeObject<HeroCard>(activity.Attachments[i].Content);
                                Console.WriteLine(heroCard.Text);
                                Console.WriteLine(activity.Attachments[i].Content.ToString());
                            }
                        }
                    }
                }
            }
        }
    }
}
