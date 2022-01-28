using System;

namespace Net011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NET01.1");

            try
            {
                TextMaterial trainMat = new TextMaterial("Hello world",
                    "description one");

                VideoMaterial videoMat = new VideoMaterial(Guid.NewGuid(),
                    "Video Material description 1",
                    "localhost://rimvydasvainutisCS/videolessons/lessson1",
                    "localhost://rimvydasvainutisCS/videolessons/lessson1/splashscreen",
                    VideoFormats.Unknown);

                LinkToNetRsc linkToNetRsc = new LinkToNetRsc(Guid.NewGuid(),
                    "Link to Net Resource 1",
                    "https://www.netsite.com/resources/resource1/lesson1.html",
                    LinkTypes.Html);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
