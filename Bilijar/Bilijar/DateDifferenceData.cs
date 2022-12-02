using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilijar
{
    class DateDifferenceData
    {
        public int Minutes;
        public long Seconds;

        public DateDifferenceData(DateTime started, DateTime ended)
        {
            var difference = ended - started;

            Minutes = difference.Minutes;
            Seconds = difference.Seconds;
        }
    }
}
