﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandClimate
{
    internal class Måling
    {
        private static int nextId = 1;
        private int Id { get; set; }

        private DateTime DateTime { get; set; }

        private double Temp { get; set; }

        private int Co2 { get; set; }

        private int AntalPersoner {  get; set; }

        private readonly Lokale Lokale;


        public Måling(DateTime dateTime, double temp, int co2, int antalPersoner, Lokale lokale)
        {
            Id = nextId++;
            DateTime = dateTime;
            Temp = temp;
            Co2 = co2;
            AntalPersoner = antalPersoner;
            Lokale = lokale; ;
        }


            public override string ToString()
        {
            return $"Lokale ID: {Id}, dato og tid: {DateTime}, temperatur: {Temp}, CO2: {Co2} ppm, personer: {AntalPersoner}";

        }














    }
}
