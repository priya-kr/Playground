namespace GitPlayground
{
    internal class SpeakerLivio : ISpeaker
    {
        public SpeakerLivio()
        {
        }

        string ISpeaker.Name => "Francescucci Livio";

        string ISpeaker.Message => " Hi guys, This is Francescucci Livio here.";
    }
}