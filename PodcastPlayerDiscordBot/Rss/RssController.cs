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

        private string LastFeed { get; set; }
        private int LastEpisodeNumber { get; set; }
        private Episode CurrentEpisode { get; set; }

        public RssController(DiscordSocketClient client, ISpeaker speaker, IFeedStorage feedStorage)
        {
            _client = client;
            _speaker = speaker;
            _feedStorage = feedStorage;
        }

        internal async Task<bool> TryAddFeedAsync(string name, string url)
        {
            var feed = new PodcastFeed(url);
            return await _feedStorage.TryAddFeedAsync(name, feed);
        }

        internal async Task<PodcastFeed> GetRssFeed(string name)
        {
            return await _feedStorage.GetFeedAsync(name);
        }

        internal async Task<Dictionary<string, PodcastFeed>> GetAllFeeds()
        {
            return await _feedStorage.GetFeedsAsync();
        }
    }
}
