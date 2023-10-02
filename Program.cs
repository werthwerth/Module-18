

using AngleSharp.Dom;
using System;
using System.Net;

namespace Module_18
{
    public class Program
    {
        static void Main(string[] args)
        {
            string url = "";
            while (string.IsNullOrEmpty(url))
            {
                Console.WriteLine("Enter youtube video url:");
                url = Console.ReadLine();
            }
            int userCommand = 0;
            while (userCommand != 3)
            {
                Console.WriteLine("Enter a command number:");
                Console.WriteLine("(1) Get video info.");
                Console.WriteLine("(2) Download video.");
                Console.WriteLine("(3) Exit.");
                userCommand = Convert.ToInt32(Console.ReadLine());
                if (userCommand == 1)
                {
                    var sender = new Sender();
                    var receiver = new Receiver();
                    var GetInfoCommand = new GetInfoCommand(receiver);
                    sender.SetCommand(GetInfoCommand);
                    sender.Run(url);
                }
                else if (userCommand == 2)
                {
                    Console.WriteLine("Enter download folder fullpath:");
                    string path = Console.ReadLine();
                    var sender = new Sender();
                    var receiver = new Receiver();
                    var DownloadCommand = new DownloadCommand(receiver);
                    sender.SetCommand(DownloadCommand);
                    sender.Run(url, path);
                }
            }
        }
    }
}