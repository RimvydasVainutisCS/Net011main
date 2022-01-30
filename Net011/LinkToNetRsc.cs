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
    }
}
