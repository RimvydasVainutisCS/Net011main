using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net011
{
    // Contents:

    // an arbitrary text description (empty or null, limited to 256 chars)
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
        public TextMaterial(string text, string description) : base(id, description)
        {
            Text = text;
            Description = description;
        }
    }
}
