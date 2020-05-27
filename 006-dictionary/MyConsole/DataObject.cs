using System;
using System.Collections.Generic;

namespace MyConsole
{
    /// <summary>Class for a data object</summary>
    class DataObject
    {        
        /// <summary>The dictionary</summary>
        protected Dictionary<string, string> keyValueDictionary;

        /// <summary>Constructor that create an empty dictionary</summary>
        public DataObject() {
            keyValueDictionary = new Dictionary<string, string>();
        }

        /// <summary>Set a value</summary>
        public void Set(String Key = "", String Value = "") 
        {
            if (keyValueDictionary.ContainsKey(Key) == true) {
                keyValueDictionary[Key] = Value;
                return;
            }

            keyValueDictionary.Add(Key, Value);
        }

        /// <summary>Get a value</summary>
        public string Get(String Key = "", String Default = "") 
        {
            if (keyValueDictionary.ContainsKey(Key) == true) {
                return keyValueDictionary[Key];
            }

            return Default;
        }
    }
}
