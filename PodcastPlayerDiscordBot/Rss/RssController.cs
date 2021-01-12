using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastPlayerDiscordBot.Rss
{
    public class RssController
    {
        private DiscordSocketClient _client;
        private ISpeaker _speaker;
        private IFeedStorage _feedStorage;

        public RssController(DiscordSocketClient client, ISpeaker speaker, IFeedStorage feedStorage)
        {
            _client = client;
            _speaker = speaker;
            _feedStorage = feedStorage;
        }
    }
}
