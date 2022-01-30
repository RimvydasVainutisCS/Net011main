using System;

namespace Net011
{
    public abstract class TrainingEntity
    {
        private string _description;
        public Guid Id
        {
            get;
            set;
        }
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
                else if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid input.");
                }
                _description = value;
            }
        }
        public TrainingEntity()
        {            
        }
    }
}
