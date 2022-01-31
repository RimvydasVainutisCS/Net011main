﻿using System;

namespace Net011
{
    public class VideoMaterial : TrainingMaterial
    {
        private string _videoContentUri;
        private string _splashScreenUri;
        private VideoFormat _videoFormats;

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

        public VideoMaterial(string videoContentUri, string splashScreenUri, VideoFormat videoFormat)
        {
            _videoContentUri = videoContentUri;
            _splashScreenUri = splashScreenUri;
            _videoFormats = videoFormat;
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
            if (!(obj is VideoMaterial))
            {
                return false;
            }
            return (Id == ((VideoMaterial)obj).Id);
        }

        public override int GetHashCode() { return 0; }
    }
}
