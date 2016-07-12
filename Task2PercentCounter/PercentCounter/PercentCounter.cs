using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentCounter
{
  public static class Counter
    {
       static Dictionary<string, int> percents = new Dictionary<string, int> {{"USA",10}, {"UKRAINE",15}, {"NORWAY",30}};
        public static string Msg { get; private set; }
       static Dictionary<string, int> additPercents = new Dictionary<string, int> { { "UKRAINE", 3 } };
       public static int GetPercent(string country, out int additionalPercent)

        {
            if (additPercents.TryGetValue(country, out additionalPercent))
            { }
            else additionalPercent = 0;

            int percent;
            if (percents.TryGetValue(country, out percent))
                return percent;
            else
            {
                Msg = "Don't have any info about this country!!!";
                return 0;
            }
            
        }
    }
}
