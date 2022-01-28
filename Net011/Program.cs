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

                VideoMaterial videoMat = new VideoMaterial("localhost://rimvydasvainutisCS/videolessons/lessson1",
                    "localhost://rimvydasvainutisCS/videolessons/lessson1/splashscreen",
                    VideoFormats.Unknown);

                videoMat.Description = "description example 111";

                LinkToNetRsc linkToNetRsc = new LinkToNetRsc("https://www.netsite.com/resources/resource1/lesson1.html",
                    LinkTypes.Html);

                var lesson1 = new TrainingLesson();
                lesson1.TrainingMaterials.Add(trainMat);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
