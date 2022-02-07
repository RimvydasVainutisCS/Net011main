using System;

namespace Net011
{
    public class TextMaterial : TrainingMaterial
    {
        private const int textLength = 10000;
        private string _text;

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (value.Length > textLength)
                {
                    throw new Exception($"Text can't be longer than {textLength} chars.");
                }
                _text = value;
            }
        }

        public TextMaterial(string text, string description)
        {
            Text = text;
            Description = description;
        }

        public override string ToString()
        {
            return Description;
        }
        public override bool Equals(object obj)
        {
            if (obj == null && (!(obj is TextMaterial)))
            {
                return false;
            }
            return (Id == ((TextMaterial)obj).Id);
        }

        public override int GetHashCode() { return 0; }
    }
}
