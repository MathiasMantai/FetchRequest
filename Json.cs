using Newtonsoft.Json;

namespace HttpFetch
{
    class Json
    {
        public static T Deserialize<T>(string obj) 
        {
            return JsonConvert.DeserializeObject<T>(obj);
        }
    }
}
