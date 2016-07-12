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

       static Dictionary<string, int> additPercents = new Dictionary<string, int> { { "UKRAINE", 3 } };
       public static int GetPercent(string country, out int additionalPercent)
        {
            try
            {
                if (additPercents.TryGetValue(country, out additionalPercent))
                    Console.WriteLine("This country " + "( " + country + " ) " + "have additional percent " + additionalPercent.ToString());
                else additionalPercent = 0;
                return percents[country];
            }
            catch (Exception)
            {
                Console.WriteLine("I don't have any info about this country");
                additionalPercent = 0;
                return 0;
            }
        }
    }
}
