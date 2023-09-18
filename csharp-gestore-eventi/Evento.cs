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

        private int spotsBooked;
        public int SpotsBooked
        {
            get
            {
                return spotsBooked;
            }
            set
            {
                SetSpotsAviable();
                spotsBooked = value;
            }
        }

        public int spotsAviable;
        public int SpotsAviable
        {
            get
            {
                return spotsAviable;
            }
            set
            {
                SetSpotsAviable();
                spotsAviable = value;
            }
        }


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
            SetSpotsAviable();
            return spotsAviable;
        }

        public int GetSpotsAviable() { return spotsAviable; }

        private int SetSpotsAviable()
        {
            spotsAviable = spotsMax - SpotsBooked;
            return this.spotsAviable;
        }

        //costruttore

        public Evento(string title, DateTime date, int spotsMax) 
        {
            this.title = title;
            this.date = date;
            this.spotsMax = spotsMax;
            SpotsBooked = 0;
            spotsAviable = SetSpotsAviable();
        }

        //metodi

        public int BookSpots(int spots) 
        { 
            if (spots > (spotsMax - SpotsBooked) || spotsMax == SpotsBooked || date < DateTime.Now)
            {
                throw new Exception(
                    "Non è possibile prenotare nuovi posti");
            }
            SetSpotsAviable();
            SpotsBooked = this.SpotsBooked + spots;
            return SpotsBooked;
        }

        public int DeleteBookedSpots(int spots) 
        {
            if ( spots > SpotsBooked || SpotsBooked == 0 || date < DateTime.Now)
            {
                throw new Exception(
                    "Non è possibile prenotare nuovi posti");
            }
            
            SpotsBooked = SpotsBooked - spots;
            SetSpotsAviable();
            return SpotsBooked;
        }

        public override string ToString()
        {
            return ($"{date.ToString("dd/MM/yyyy")} - {title}");
        }

        public string SpotsReview()
        {
            SetSpotsAviable();
            return (@$"
    Capienza evento: {spotsMax}
    Posti prenotati: {SpotsBooked}
    Posti disponibili: {spotsAviable}
            ");
        }
    }
}
