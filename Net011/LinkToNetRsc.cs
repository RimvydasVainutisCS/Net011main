using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net011
{
    enum LinkTypes
    {
        Unknown,
        Html,
        Image,
        Audio,
        Video
    }
    internal class LinkToNetRsc : TrainingEntity
    {
        private string _contentUri;
        private LinkTypes _linkType;

        public LinkToNetRsc(Guid id, string description, string contentUri, LinkTypes linkType) : base(id, description)
        {
            _contentUri = contentUri;
            _linkType = linkType;
        }
    }
}
