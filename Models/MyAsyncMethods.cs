using System.Net.Http;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength()
        {
          HttpClient client = new HttpClient();

          var httpMessage = await client.GetAsync("https://github.com/codejockie");

          return httpMessage.Content.Headers.ContentLength;
        }
    }
}