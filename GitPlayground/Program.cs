using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPlayground
{
    class Program
    {
        private static List<ISpeaker> speakers;

        static void Main(string[] args)
        {

            speakers = new List<ISpeaker>();
            speakers.Add(new SpeakerLivio());
            speakers.Add(new SpeakerJohn());
            speakers.Add(new SpeakerMark());
            speakers.Add(new SpeakerAlex());
            speakers.Add(new SpeakerOliver());

            Console.WriteLine("Hello World!...");


            foreach (var messageSpeaker in speakers)
            {
                Console.WriteLine(string.Format("Message from the speaker:{0}. Message says:{1}", messageSpeaker.Name, messageSpeaker.Message));
            }

            Console.WriteLine("Now press a key to continue...there isn't much else");
            Console.ReadKey();
        }
    }
}
