using System.Threading.Tasks;
using System.Net.Http;
using System;

namespace URLRank_App.Models
{
    public class GoogleSearchClient : IGoogleSearchClient
    {
        public string googleurl = @"http://www.google.com/search?num=100&q=<search_string>";

        public async Task<string> SearchGoogleAsync(string search_text)
        {
            var url = Build_url(search_text);

            try { 
            using (var httpclient = new HttpClient())
            {
                var response = await httpclient.GetAsync(url);
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
            }
            catch(Exception ex)
            {
                throw new Exception($"HTTP Exception:{ex.Message}");
            }
        }

        private string Build_url(string search_text)
        {
            var url = "";
            search_text = search_text.Replace(' ', '+');
            url = googleurl.Replace("<search_string>", search_text);

            return url;
        }

    }
}
