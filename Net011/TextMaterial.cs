using System;

namespace Net011
{
    public class TextMaterial : TrainingMaterial
    {
        private string _text;

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (value.Length > 10000)
                {
                    throw new Exception("Text can't be longer than 10 000 chars.");
                }
                _text = value;
            }
        }

        public TextMaterial(string text, string description)
        {
            Text = text;
            Description = description;
        }
    }
}
