namespace Media
{
    internal class Video : IMedia
    {
        public string DisplayMedia()
        {
            return $"{GetType().Name}: Video wird angezeigt.";
        }

        public string PlayMedia()
        {
            return $"{GetType().Name}: Video wird gestartet.";
        }

        public string StopMedia()
        {
            return $"{GetType().Name}: Video wird gestoppt.";
        }
    }
}