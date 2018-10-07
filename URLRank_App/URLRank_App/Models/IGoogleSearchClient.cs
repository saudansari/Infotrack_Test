using System.Threading.Tasks;

namespace URLRank_App.Models
{
    public interface IGoogleSearchClient
    {
        Task<string> SearchGoogleAsync(string url);
    }
}
