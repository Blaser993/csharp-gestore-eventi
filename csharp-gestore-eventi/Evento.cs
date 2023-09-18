﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Evento
    {
        public string title;

        public DateTime date;

        public int spotsMax;

        public int SpotsBooked {  get; private set; }

        // getter e setter

        public string GetTitle() { return title; }

        public string SetTitle() {
            title = title.Trim();
            
            if (title == "")
            {
                throw new Exception(
                    "Il titolo non può essere vuoto");
            } 
            return title;
        }

        public DateTime GetDate() { return date; }

        public DateTime SetDate() {

            if(date == date)
            {
                throw new Exception(
                  "Questa data non è disponibile");
            }
            return date;
        }

        public int GetSpotsMax() {  return spotsMax; }

        private int SetSpotsMax() {

            if (spotsMax < 0)
            {
                spotsMax = 0;
            }
            return spotsMax; 
        }

        //costruttore

        public Evento(string title, DateTime date, int spotsMax) 
        {
            this.title = title;
            this.date = date;
            this.spotsMax = spotsMax;
            this.SpotsBooked = 0;
        }

        //metodi

        public int BookSlots(int slots) 
        { 
            return 
        }
    }
}