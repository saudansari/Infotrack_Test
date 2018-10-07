using System;
using System.Collections.Generic;

namespace URLRank_App.Models
{
    public class GoogleSearchParser : IGoogleSearchParser
    {
        public List<string> Search_ExtractClassR(string search_result)
        {
            var results = new List<string>();

            if (string.IsNullOrEmpty(search_result))
                return null;

            var i = 0;
            try
            { 
                while((i = search_result.IndexOf("<h3 class=\"r\"", i)) != -1)
                {
                    var j = 0;
                    var remaining = search_result.Substring(i);
                    while ((j = remaining.IndexOf("</h3>", j)) != -1)
                    {
                        var substr = remaining.Substring(0, j + 5);
                        results.Add(substr);
                        break;
                    }
                    i++;
                }
                return results;
            }
            catch(Exception ex)
            {
                throw new Exception($"Comparison Failed {ex.Message}");
            }
        }



    }
}
