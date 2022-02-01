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
                TextMaterial trainMat = new TextMaterial("Hello world");
                trainMat.Description = "trainMat description goes here";

                VideoMaterial videoMat = new VideoMaterial("localhost://rimvydasvainutisCS/videolessons/lessson1",
                    "localhost://rimvydasvainutisCS/videolessons/lessson1/splashscreen",
                    VideoFormat.Unknown);                
                videoMat.Description = "description example 111";

                // 4 create extension method...
                videoMat.SetId();
                // 5 check if ID is same
                Console.WriteLine(videoMat.Equals(videoMat));

                LinkToNetRsc linkToNetRsc = new LinkToNetRsc("https://www.netsite.com/resources/resource1/lesson1.html",
                    LinkType.Html);

                var lesson1 = new TrainingLesson();
                
                lesson1.TrainingMaterials.Add(trainMat);
                lesson1.TrainingMaterials.Add(trainMat);
                lesson1.TrainingMaterials.Add(linkToNetRsc);
                Console.WriteLine(trainMat.ToString());
                Console.WriteLine(videoMat.ToString());
                Console.ReadLine();
                var result1 = lesson1.GetTrainingType();

                var lesson1Clone = lesson1.Clone();
                lesson1Clone.TrainingMaterials.Add(videoMat);
                var result1Clone = lesson1Clone.GetTrainingType();

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
