using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using System.Runtime.Serialization;

namespace mvc_cowde.Models { 
    [DataContract]
    public class ConversorJSON
    {
        public ConversorJSON()
        {}

        public string ConverteObjectParaJSon<T>(T obj)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream();
                ser.WriteObject(ms, obj);
                string jsonString = Encoding.UTF8.GetString(ms.ToArray());
                ms.Close();
                return jsonString;
            }
            catch
            {
                throw;
            }
        }
        public T ConverteJSonParaObject<T>(string jsonString)
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
                T obj = (T)serializer.ReadObject(ms);
                return obj;
            }
            catch
            {
                throw;
            }
        }
    }
}
