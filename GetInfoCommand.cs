using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;


namespace Module_18
{
    class GetInfoCommand: Command
    {
        Receiver receiver;
        public GetInfoCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }


        
        public override void Run(string url, string path = "")
        {
            YoutubeClient youtubeClient = new YoutubeClient();
            receiver.Operation(youtubeClient.Videos.GetAsync(url).Result.Description);
        }
    }
}
