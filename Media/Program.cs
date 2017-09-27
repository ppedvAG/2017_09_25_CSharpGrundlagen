using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            var audio = new Audio();
            var picture = new Picture();
            var video = new Video();

            Console.WriteLine("Medium 1:");
            UseMedia(picture);

            Console.WriteLine("Medium 2:");
            UseMedia(video);

            Console.WriteLine("Medium 3:");
            UseMedia(audio);

            Console.ReadLine();
        }

        private static void UseMedia(IMedia media)
        {
            Console.WriteLine(media.DisplayMedia());
            Console.WriteLine(media.PlayMedia());
            Console.WriteLine(media.StopMedia());
        }
    }
}
