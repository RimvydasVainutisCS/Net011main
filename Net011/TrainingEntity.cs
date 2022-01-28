using System;

namespace Net011
{
    public abstract class TrainingEntity
    {
        private string _description;
        public System.Guid Id { get; set; }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value.Length > 256)
                {
                    throw new Exception("Description is longer than 256 chars.");
                }
                else if (value == null)
                {
                    throw new Exception("Description can't have 'null' value.");
                }
                else if (value.Length < 1)
                {
                    throw new Exception("Description can't have 'empty' value.");
                }
                _description = value;
            }
        }
        public TrainingEntity(System.Guid id, string description)
        {
            Id = id;
            Description = description;
        }

    }
}
