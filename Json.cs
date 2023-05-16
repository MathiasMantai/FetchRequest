using Newtonsoft.Json;

namespace HttpFetch
{
    public class Json
    {
        public static T Deserialize<T>(string obj) 
        {
            return JsonConvert.DeserializeObject<T>(obj)!;
        }

        public static string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj)!;   
        }
    }
}