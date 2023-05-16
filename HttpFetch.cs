namespace HttpFetch
{
    public class FetchRequest
    {
        HttpResponseMessage? Content;
        public async Task New(string url)
        {
            Uri uri = new Uri(url);
            using(var client = new HttpClient()) 
            {
                this.Content = await client.GetAsync(uri);
                var con = await client.GetAsync(uri);   
            }
        }

        public string ReadString()
        {
            var content = this.Content!.Content.ReadAsStringAsync().Result;
            return content;
        }
    }
}