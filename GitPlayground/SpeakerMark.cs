namespace GitPlayground
{
    internal class SpeakerMark : ISpeaker
    {
        public SpeakerMark()
        {
        }

        string ISpeaker.Name => "Mark";

        string ISpeaker.Message => " I can hear you now....";
    }
}