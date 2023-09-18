using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        public string title;
        public List<Evento> eventi;


        //costruttore
        public ProgrammaEventi(string title, List<Evento> eventi)
        {
            this.title = title;
            this.eventi = new List<Evento>();
        }


        //metodi

        public Evento NewEventInList(Evento evento) 
        {
            eventi.Add(evento);

            return evento;
        }

        public List<Evento> ListOfEventAtDate(DateTime date)
        {
            List<Evento> eventsOnDate = new List<Evento>();
            foreach (Evento evento in eventi)
            {
                if (evento.date == date) 
                {
                    eventsOnDate.Add(evento);
                }
            }
            return eventsOnDate;
        }
    }


}
