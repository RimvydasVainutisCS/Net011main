using System;

namespace Net011
{
    public enum VideoFormats
    {
        Unknown,
        Avi,
        Mp4,
        Flv
    };

    public class VideoMaterial : TrainingEntity
    {
        private string _videoContentUri;
        private string _splashScreenUri;
        private VideoFormats _videoFormats;

        public string VideoContentUri
        {
            get
            {
                return _videoContentUri;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Video Content URI can't be 'empty'!");
                }
                _videoContentUri = value;
            }
        }

        public string SplashScreenUri
        {
            get
            {
                return _splashScreenUri;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Video Content splash screen URI can't be 'empty!");
                }
                _splashScreenUri = value;
            }
        }

        public VideoMaterial(Guid id, string description, string videoContentUri, string splashScreenUri, VideoFormats videoFormat) : base(id, description)
        {
            _videoContentUri = videoContentUri;
            _splashScreenUri = splashScreenUri;
            _videoFormats = videoFormat;
        }
    }
}
