namespace GitPlayground
{
    internal class SpeakerAlex : ISpeaker
    {
        public SpeakerAlex()
        {
        }

        string ISpeaker.Name => "Alex";

        string ISpeaker.Message => "Wow, this is a powerful tool!";
    }
}