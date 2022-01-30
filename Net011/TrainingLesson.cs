using System.Collections.Generic;
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
            //issiaiskinti, kaip gauti x tipa
            if (TrainingMaterials.Any(x => typeof(GetType) == GetType(VideoMaterial)))
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
