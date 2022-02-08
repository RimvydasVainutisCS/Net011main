using Net011;
using System;

namespace CustomExtensions
{
    public static class ExtensionMethods
    {
        public static void SetId(this TrainingEntity entity)
        {
            entity.Id = Guid.NewGuid();
        }
    }
}
