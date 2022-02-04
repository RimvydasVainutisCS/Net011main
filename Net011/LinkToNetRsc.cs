namespace Net011
{
    internal class LinkToNetRsc : TrainingMaterial
    {
        private string _contentUri;
        private LinkType _linkType;

        public LinkToNetRsc(string contentUri, LinkType linkType)
        {
            _contentUri = contentUri;
            _linkType = linkType;
        }

        public override string ToString()
        {
            return Description;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is LinkToNetRsc))
            {
                return false;
            }
            return Id == (obj as LinkToNetRsc)?.Id;
        }

        public override int GetHashCode() { return 0; }


    }
}
