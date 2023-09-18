using System;
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

        public int spotsBooked;

        public int spotsAviable;

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

        public int GetSpotsBooked() { return spotsBooked; }

        private int SetSpotsBooked()
        {

            return spotsAviable;
        }

        public int GetSpotsAviable() { return spotsAviable; }

        private int SetSpotsAviable()
        {
            spotsAviable = spotsMax - spotsBooked;
            return this.spotsAviable;
        }

        //costruttore

        public Evento(string title, DateTime date, int spotsMax) 
        {
            this.title = title;
            this.date = date;
            this.spotsMax = spotsMax;
            spotsBooked = 0;
            this.spotsAviable = SetSpotsAviable();
        }

        //metodi

        public int BookSpots(int spots) 
        { 
            if (spots > (spotsMax - spotsBooked) || spotsMax == spotsBooked || date < DateTime.Now)
            {
                throw new Exception(
                    "Non è possibile prenotare nuovi posti");
            }
            spotsBooked = this.spotsBooked + spots;
            return spotsBooked;
        }

        public int DeleteBookedSpots(int spots) 
        {
            if ( spots > spotsBooked || spotsBooked == 0 || date < DateTime.Now)
            {
                throw new Exception(
                    "Non è possibile prenotare nuovi posti");
            }
            spotsBooked = this.spotsBooked - spots;
            return this.spotsBooked;
        }

        public override string ToString()
        {
            return ($"{date.ToString("dd/MM/yyyy")} - {title}");
        }

        public string SpotsReview()
        {
            return (@$"
    Capienza evento: {spotsMax}
    Posti prenotati: {spotsBooked}
    Posti disponibili: {spotsAviable}
            ");
        }
    }
}
