using System;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http;
using System.Text.Encodings;
using System.Text.Json;

namespace Assignment5.Infrastructure
{
    //This is a tool to convert our cart object to a Json strong file, and then back (because we can't store Carts in a session
    public static class SessionExtensions
    {
        public static void SetJson (this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetJson<T> (this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}
