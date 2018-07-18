namespace GitPlayground
{
    internal class SpeakerJohn : ISpeaker
    {
        public SpeakerJohn()
        {
        }

        string ISpeaker.Name => "John";

        string ISpeaker.Message => " I also would like to add that GIT is great.";
    }
}