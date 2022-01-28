using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net011
{
    public static class ExtensionMethods
    {
        public static void SetId(TrainingEntity entity)
        {
            entity.Id = Guid.NewGuid();
        }
    }
}
