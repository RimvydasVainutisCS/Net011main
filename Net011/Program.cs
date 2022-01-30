using CustomExtensions;
using System;
using System.Collections.Generic;

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
                    VideoFormat.Unknown);

                videoMat.Description = "description example 111";

                // 4 create extension method...
                videoMat.SetId();

                LinkToNetRsc linkToNetRsc = new LinkToNetRsc("https://www.netsite.com/resources/resource1/lesson1.html",
                    LinkType.Html);

                var lesson1 = new TrainingLesson();
                lesson1.TrainingMaterials.Add(trainMat);
                lesson1.TrainingMaterials.Add(videoMat);
                lesson1.TrainingMaterials.Add(linkToNetRsc);
                var result1 = lesson1.GetTrainingType();

                var lesson2 = new TrainingLesson
                {
                    TrainingMaterials = new List<TrainingMaterial> { trainMat, linkToNetRsc}
                };
                var result2 = lesson2.GetTrainingType();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
