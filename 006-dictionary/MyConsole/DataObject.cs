using System;
using System.Collections.Generic;

namespace MyConsole
{

    class DataObjectItem
    {
        public string Type = "";
        public string Value = "";

        public DataObjectItem(String Type="", String Value="") {
            this.Type = Type;
            this.Value = Value;
        }

        public void Set(Boolean Value = false) {
            this.Value = "false";
            if (Value == true) {
                this.Value = "true";
            }
            Type = "boolean";
        }
        public void Set(int Value = 0) {
            this.Value = Value.ToString();
            Type = "integer";
        }
        public void Set(Double Value = 0.0) {
            this.Value = Value.ToString();
            Type = "double";
        }
        public void Set(String Value = "") {
            this.Value = Value;
            Type = "string";
        }

        public Boolean GetBoolean(Boolean Default = false) 
        {
            if (Type != "boolean") {
                return Default;
            }

            if (Value == "true") {
                return true;
            }

            return false;
        }

        public int GetInteger(int Default = 0) 
        {
            if (Type != "integer") {
                return Default;
            }

            int myInt = 0;

            if (Int32.TryParse(Value, out myInt) == true) {
                return myInt;
            }

            return Default;
        }

        public double GetDouble(double Default = 0.0) 
        {
            if (Type != "double") {
                return Default;
            }

            Double myDouble = 0.0;

            if (Double.TryParse(Value, out myDouble) == true) {
                return myDouble;
            }

            return Default;
        }

        public String GetString(String Default = "") 
        {
            if (Type != "string") {
                return Default;
            }

            return Value;
        }

    }

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
