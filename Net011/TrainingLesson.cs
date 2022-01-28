using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net011
{
    public abstract class TrainingLesson : TrainingEntity
    {
        private string _trainingLessonType;
        protected TrainingLesson(Guid id, string description) : base(id, description)
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
