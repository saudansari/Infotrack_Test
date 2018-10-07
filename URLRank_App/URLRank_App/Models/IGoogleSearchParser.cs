using System.Collections.Generic;

namespace URLRank_App.Models
{
    public interface IGoogleSearchParser
    {
        List<string> Search_ExtractClassR(string search_result);

        //List<string> GetH2_Tags(string input);

        //List<string> GetH3_Tags(string input);
    }
}
