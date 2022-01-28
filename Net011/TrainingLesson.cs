using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net011
{
    public class TrainingLesson : TrainingEntity
    {
        private string _trainingLessonType;
        public List<TrainingMaterial> TrainingMaterials { get; set; } = new List<TrainingMaterial>();
        public TrainingLesson()
        {
        }

        // includes a set of training materials
        // for example: trainingLessonOne = 5x text material, 2x video material, 1x link to a network resource
        public string GetTrainingType()
        {
            return string.Empty;
        }
    }
}
