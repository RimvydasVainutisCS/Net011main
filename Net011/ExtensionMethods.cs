using Net011;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
