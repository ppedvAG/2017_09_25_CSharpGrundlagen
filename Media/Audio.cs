namespace Media
{
    internal class Audio : IMedia
    {
        public string DisplayMedia()
        {
            return $"{GetType().Name}: DisplayMedia() wird nicht unterstützt.";
        }

        public string PlayMedia()
        {
            return $"{GetType().Name}: Audio gestartet.";
        }

        public string StopMedia()
        {
            return $"{GetType().Name}: Audio gestoppt.";
        }
    }
}