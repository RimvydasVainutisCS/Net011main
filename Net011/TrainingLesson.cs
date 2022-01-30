﻿using System.Collections.Generic;
using System.Linq;

namespace Net011
{
    public class TrainingLesson : TrainingEntity
    {
        public List<TrainingMaterial> TrainingMaterials { get; set; } = new List<TrainingMaterial>();
        public TrainingLesson()
        {
        }

        public LessonType GetTrainingType()
        {
            var res1 = TrainingMaterials.Where(x => x.Description == "description one");            // kol nepanaudota, ToList, uzklauso nevykdoma/negauna rezultato
            var res2 = TrainingMaterials.Where(x => x.Description == "description one").ToList();   // panaudojus ToList, uzklausa ivykdyta/gautas rezultatas
            //var res3 = TrainingMaterials.Where(x => x.Description == "description two").First();

            try
            {
                var res3 = TrainingMaterials.Where(x => x.Description == "description two").First();
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
                throw;
            }

            var res4 = TrainingMaterials.Where(x => x.Description == "description two").FirstOrDefault();
            if (TrainingMaterials.Any(x => x.GetType() == typeof(VideoMaterial)))
            {
                return LessonType.VideoLesson;
            }
            else
            {
                return LessonType.TextLesson;
            }
        }
    }
}
