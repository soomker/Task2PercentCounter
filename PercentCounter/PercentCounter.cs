using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentCounter
{
    static class Counter
    {
       static Dictionary<string, int> percents = new Dictionary<string, int> {{"USA",10}, {"Ukraine",15}, {"Norway",30}};
       
        
       public static int GetPercent(string country)
        {
            try
            {
              return percents[country];
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
