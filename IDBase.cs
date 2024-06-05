using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandClimate
{
    public class IDBase
    {
        private int id;
        internal static int nextId = 0;

        internal IDBase() 
        {
            Id = nextId++;
        }

        internal int Id { get; set; }

    }
}
