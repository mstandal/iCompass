using System;
using System.Collections.Generic;
using System.Text;

namespace iCompass
{
    public class CompassRoseCardinalCalculator
    {
        //
        // The eight principal winds and the eight half-winds together form the 
        // 16-wind compass rose, with each compass point at a ​22 1⁄2° angle from its two neighbors.
        // Half way between values is 11.5
        //
        private const double HalfCardinal = 11.5;
        private static IDictionary<double, string> Cardinals = new Dictionary<double, string>()
              {
                {0,      "N"    },
                {22.5,   "NNE"  },
                {45,     "NE"   },
                {67.5,   "ENE"  },
                {90,     "E"    },
                {112.5,  "ESE"  },
                {135,    "SE"   },
                {157.5,  "SSE"  },
                {180,    "S"    },
                {202.5,  "SSW"  },
                {225,    "SW"   },
                {247.5,  "WSW"  },
                {270,    "W"    },
                {292.5,  "WNW"  },
                {315,    "NW"   },
                {337.5,  "NNW"  },
                {360,    "N"    },
              };
        public static string GetCardinalFromHeading(double Heading)
        {
            string SelectedCardinal = "N";

            foreach (KeyValuePair<double, string> Cardinal in Cardinals)
            {
                if(Math.Min(Cardinal.Key + HalfCardinal, Heading) == Heading)
                {
                    SelectedCardinal = Cardinal.Value;
                    break;
                }                   
            }
         
            return SelectedCardinal;
        }
    }
}
