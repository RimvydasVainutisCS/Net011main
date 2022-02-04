﻿using System;

namespace Net011
{
    public abstract class TrainingEntity
    {
        private string _description;
        public int maxLenghtOfDescription = 256;
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid input.");
                }
                
                if (value.Length > maxLenghtOfDescription)
                {
                    throw new Exception("Description is longer than 256 chars.");
                }
                else 
                _description = value;
            }
        }
        public TrainingEntity()
        {            
        }
    }
}
