﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;

namespace ConsoleApplication2.Models
{
    public partial class Fact
    {
        private string _key;
        
        /// <summary>
        /// Optional. The key for this Fact
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }
        
        private string _value;
        
        /// <summary>
        /// Optional. The value for this Fact
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Fact class.
        /// </summary>
        public Fact()
        {
        }
    }
}
