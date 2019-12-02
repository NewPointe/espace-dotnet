using System;
using System.Threading.Tasks;

using NewPointe.Util;

namespace NewPointe.eSpace.Cli
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new Client();

            Console.Write("ESpace Username: ");
            var espaceUsername = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(espaceUsername)) return;

            Console.Write("ESpace Password: ");
            var espacePassword = ConsoleUtil.ReadPassword();

            if(string.IsNullOrWhiteSpace(espacePassword)) return;

            Console.WriteLine("");

            client.SetCredentials(espaceUsername, espacePassword);

            var eSpaceEvents = await client.GetEvents();

            foreach (var eSpaceEvent in eSpaceEvents)
            {
                Console.WriteLine(eSpaceEvent.EventName);
            }

        }
    }
}
