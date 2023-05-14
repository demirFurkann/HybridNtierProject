using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.COMMON.Tools
{
    public static class SessionExtansion
    {
        public static void SetObject(this ISession session,string key,object value)
        {
            string objectString = JsonConvert.SerializeObject(value);
            session.SetString(key, objectString);

        }

        public static T GetObject<T>(this ISession session,string key)
        {
            string objectString=session.GetString(key);
            if (string.IsNullOrEmpty(objectString)) throw new Exception("Session nesnesi bulnumadı");
            T deserializedObject=JsonConvert.DeserializeObject<T>(objectString);
            return deserializedObject;
        }
    }
}
