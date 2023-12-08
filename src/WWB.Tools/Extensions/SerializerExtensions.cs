using Newtonsoft.Json;
using System;
using System.Text.RegularExpressions;

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

        /// <summary>
        /// 手机号掩码
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string PhoneToAnonymous(this string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                throw new ArgumentNullException("phone is empty");
            }

            return Regex.Replace(phone, "(\\d{3})\\d{4}(\\d{4})", "$1****$2");
        }
    }
}