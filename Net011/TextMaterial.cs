using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net011
{
    public class TextMaterial : TrainingEntity
    {
        private string _text;
        private static Guid id;

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

        // ask Igor if this is the right way
        public TextMaterial(string text, string description)
        {
            Text = text;
            Description = description;
        }
    }
}
