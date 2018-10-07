using System.Collections.Generic;

namespace URLRank_App.Models
{
    public interface IGoogleSearchParser
    {
        List<string> Search_ExtractClassR(string search_result);
    }
}
