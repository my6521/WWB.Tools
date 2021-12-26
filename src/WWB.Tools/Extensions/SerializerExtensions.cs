using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WWB.Tools.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class SerializerExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(this Object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ToObject<T>(this string val)
        {
            return JsonConvert.DeserializeObject<T>(val);
        }
    }
}