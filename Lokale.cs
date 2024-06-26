﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandClimate
{
    internal class Lokale : IDBase
    {
        //private static int nextId = 1;
        //private int Id { get; set; }
        public string LokaleNummer { get; set; }
        private int MaxAntalPersoner { get; set; }


        public Lokale(string lokaleNummer, int maxAntalPersoner) : base()
        {
            Id = nextId;

            LokaleNummer = lokaleNummer;
            MaxAntalPersoner = maxAntalPersoner;

        }


        public override string ToString()
        {
            return $"Lokale ID: {Id}, lokale nummer: {LokaleNummer}, kapacitet: {MaxAntalPersoner}";
        }















    }
}
