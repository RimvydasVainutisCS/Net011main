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
                //----- Creating 3 Text Materials -----//
                TextMaterial trainMat1 = new TextMaterial("Hello, World!",
                                                     "trainMat1 description.");
                trainMat1.SetId();

                TextMaterial trainMat2 = new TextMaterial("Hello, Mercury!",
                                                     "trainMat2 description.");
                trainMat2.SetId();

                TextMaterial trainMat3 = new TextMaterial("Hello, Venus!",
                                                     "trainMat3 description.");
                trainMat3.SetId();

                //----- Creating 3 Video Materials -----//
                VideoMaterial videoMat1 = new VideoMaterial("localhost://rimvydasvainutisCS/videolessons/lessson1",
                    "localhost://rimvydasvainutisCS/videolessons/lessson1/splashscreen",
                    VideoFormat.Mp4);
                videoMat1.SetId();
                videoMat1.Description = "Video material 1 description.";

                VideoMaterial videoMat2 = new VideoMaterial("localhost://rimvydasvainutisCS/videolessons/lessson2",
                    "localhost://rimvydasvainutisCS/videolessons/lessson2/splashscreen",
                    VideoFormat.Avi);
                videoMat2.SetId();
                videoMat2.Description = "Video material 2 description.";

                VideoMaterial videoMat3 = new VideoMaterial("localhost://rimvydasvainutisCS/videolessons/lessson3",
                    "localhost://rimvydasvainutisCS/videolessons/lessson3/splashscreen",
                    VideoFormat.Flv);
                videoMat3.SetId();
                videoMat3.Description = "Video material 3 description.";

                //----- Creating 3 Links to Network resource -----//
                LinkToNetRsc linkToNetRsc1 = new LinkToNetRsc("https://www.netsite.com/resources/resource1/lesson1.html",
                    LinkType.Html);
                linkToNetRsc1.SetId();
                linkToNetRsc1.Description = "Link to Net resource 1 description.";

                LinkToNetRsc linkToNetRsc2 = new LinkToNetRsc("https://www.netsite.com/resources/resource2/lesson2.html",
                    LinkType.Html);
                linkToNetRsc2.SetId();
                linkToNetRsc2.Description = "Link to Net resource 2 description.";

                LinkToNetRsc linkToNetRsc3 = new LinkToNetRsc("https://www.netsite.com/resources/resource3/lesson3.html",
                    LinkType.Html);
                linkToNetRsc3.SetId();
                linkToNetRsc3.Description = "Link to Net resource 3 description.";

                // 5 check if ID is same
                Console.WriteLine("Is videoMat1 ID == videoMat1 ID?: " + videoMat1.Equals(videoMat1));
                Console.WriteLine("Is videoMat1 ID == videoMat2 ID?: " + videoMat1.Equals(videoMat2));

                //----- Creating Lesson 1 -----//
                var lesson1 = new TrainingLesson();

                lesson1.TrainingMaterials.Add(trainMat1);
                lesson1.TrainingMaterials.Add(trainMat2);
                lesson1.TrainingMaterials.Add(linkToNetRsc1);
                lesson1.SetId();
                lesson1.Description = "lesson1 description goes here!";
                lesson1.SetVersion(new byte[8] { 2, 0, 2, 2, 0, 2, 0, 1});

                var lesson1type = lesson1.GetTrainingType();
                Console.WriteLine($"Lesson 1 training type is: {lesson1type}.");
                Console.WriteLine($"The ID of lesson 1 is: {lesson1.Id}");
                Console.WriteLine($"The ID of videoMat 1 is: {videoMat1.Id}");

                //----- Creating Lesson 2 (adding items through parameters) -----//
                var lesson2 = new TrainingLesson
                {
                    TrainingMaterials = new List<TrainingMaterial> { trainMat1, trainMat2, videoMat2, videoMat3, linkToNetRsc2 }
                };
                lesson2.Description = "lesson2 description goes here!";
                lesson2.SetId();
                lesson2.SetVersion(new byte[8] { 72, 101, 108, 108, 111, 32, 87, 111 });

                var lesson2type = lesson2.GetTrainingType();
                var lesson2version = lesson2.GetVersion();

                Console.WriteLine($"Lesson 2 training type is: {lesson2type}.");
                Console.WriteLine($"Lesson 2 Version is: {lesson2version}.");

                //----- Creating a Clone of Lesson 1 and adding Video Material to change the type of Lesson from Text to Video -----//
                var lesson1Clone = (TrainingLesson)lesson1.Clone();
                lesson1Clone.Description = "Clone of lesson 1 description.";
                lesson1Clone.SetId();
                lesson1Clone.TrainingMaterials.Add(videoMat1);
                var lesson1CloneType = lesson1Clone.GetTrainingType();

                Console.WriteLine($"Lesson 1 Clone training type is: {lesson1CloneType}.");
                Console.WriteLine($"Lesson 1 Clone ID is: {lesson1Clone.Id}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
