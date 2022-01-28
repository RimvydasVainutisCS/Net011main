using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net011
{    
    internal class LinkToNetRsc : TrainingEntity
    {
        private string _contentUri;
        private LinkTypes _linkType;

        public LinkToNetRsc(string contentUri, LinkTypes linkType)
        {
            _contentUri = contentUri;
            _linkType = linkType;
        }
    }
}
