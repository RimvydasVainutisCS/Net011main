using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net011
{
    public interface IVersionable
    {
        byte[] GetVersion();
        void SetVersion(byte[] version);
    }
}
