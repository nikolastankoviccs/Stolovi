using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilijar
{
    class Table
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Playing { get; set; }

        public DateTime Started { get; set; }

        public DateTime Ended { get; set; }
    }
}
