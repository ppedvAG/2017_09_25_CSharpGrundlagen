namespace Media
{
    internal class Picture : IMedia
    {
        public string DisplayMedia()
        {
            return $"{GetType().Name}: Bild wird angezeigt.";
        }

        public string PlayMedia()
        {
            return $"{GetType().Name}: PlayMedia() wird nicht unterstützt.";
        }

        public string StopMedia()
        {
            return $"{GetType().Name}: Bild wird ausgeblendet.";
        }
    }
}