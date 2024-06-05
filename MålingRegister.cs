using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandClimate
{
    internal class MålingRegister
    {

        private List<Måling> målinger;

        public MålingRegister()
        {
            målinger = new List<Måling>();
        }

        public void OpretMåling(DateTime dateTime, double temp, int co2, int antalPersoner, Lokale lokale)
        {
            målinger.Add(new Måling(DateTime.Now, temp, co2, antalPersoner, lokale));
        }

        public Måling HentMåling(int id)
        {
            foreach (Måling m in målinger)
            {
                if (m.Id == id)
                {
                    return m;
                }
                return null;
            }
            return null;
        }

        public void PrintAlleMålinger()
        {
            if (målinger == null)
            {
                return;
            }
            else
            {
                foreach (Måling m in målinger)
                {
                    Console.WriteLine(m.ToString());
                }
            }
            

        }


        public int AntalUlovligeCO2Målinger()
        {
            int result = 0;
            if (målinger == null)
                return result;

            foreach (Måling m in målinger)
            {
                if (m.Co2 > 1000)
                {
                    result++;
                }
            }
            return result;
        }



















    }
}
