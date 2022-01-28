using System;

namespace Net011
{
    public abstract class TrainingEntity
    {
        private string _description;
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
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
                //else if (value == null)
                //{
                //    throw new Exception("Description can't have 'null' value.");
                //}
                //else if (value.Length < 1)
                //{
                //    throw new Exception("Description can't have 'empty' value.");
                //}
                _description = value;
            }
        }
        public TrainingEntity()
        {            
        }

    }
}
