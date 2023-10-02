using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Module_18
{
    class DownloadCommand : Command
    {
        Receiver receiver;
        public DownloadCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public async override void Run(string url, string path = "")
        {
            YoutubeClient youtubeClient = new YoutubeClient();
            await youtubeClient.Videos.DownloadAsync(url, path);
            receiver.Operation("Download start");
        }
    }
}
