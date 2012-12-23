using System;
using System.Collections.Generic;

namespace GreenlakeChristmas.FourSquare.Objects
{
    public abstract class FSBase
    {
        protected FSBase(object dict)
        {
            if (!(dict is Dictionary<string, object>)) return;
            this.Dictionary = dict as Dictionary<string, object>;
        }

        protected Dictionary<string, object> Dictionary { get; set; }

        protected string GetString(string key)
        {
            return this.Dictionary.ContainsKey(key) ? this.Dictionary[key].ToString() : string.Empty;
        }

        protected bool? GetBool(string key)
        {
            if (this.Dictionary.ContainsKey(key) && this.Dictionary[key] is bool)
            {
                return Convert.ToBoolean(this.Dictionary[key]);
            }
            return null;
        }

        protected int? GetInt(string key)
        {
            if (this.Dictionary.ContainsKey(key) && this.Dictionary[key] is int)
            {
                return Convert.ToInt32(this.Dictionary[key]);
            }
            return null;
        }

        protected double? GetDouble(string key)
        {
            if (this.Dictionary.ContainsKey(key) && this.Dictionary[key] is double)
            {
                return Convert.ToDouble(this.Dictionary[key]);
            }
            return null;
        }

        protected decimal? GetDecimal(string key)
        {
            if (this.Dictionary.ContainsKey(key) && this.Dictionary[key] is decimal)
            {
                return Convert.ToDecimal(this.Dictionary[key]);
            }
            return null;
        }

        protected object GetObject(string key)
        {
            return (this.Dictionary.ContainsKey(key) ? this.Dictionary[key] : null);
        }

        protected Dictionary<string,object> GetDictionary(string key)
        {
            return (this.Dictionary.ContainsKey(key) ? this.Dictionary[key] as Dictionary<string, object> : null);
        }
 
        protected object[] GetArray(string key)
        {
            return (this.Dictionary.ContainsKey(key) ? (object[]) this.Dictionary[key] : null);
        }
    }
}