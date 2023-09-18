using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        public string Title { get; set; }
        public List<Evento> Eventi {  get; set; }


        //costruttore
        public ProgrammaEventi(string title)
        {
            this.Title = title;
            this.Eventi = new List<Evento>();
        }


        //metodi

        public Evento NewEventInList(Evento evento) 
        {
            Eventi.Add(evento);

            return evento;
        }

        public List<Evento> ListOfEventAtDate(DateTime date)
        {
            List<Evento> eventsOnDate = new List<Evento>();
            foreach (Evento evento in Eventi)
            {
                if (evento.date == date) 
                {
                    eventsOnDate.Add(evento);
                }
            }
            return eventsOnDate;
        }

        public List<Evento> EmptyList(List<Evento> eventi)
        {
            eventi.Clear();
            return new List<Evento>();
        }

        public int CountEvents(List<Evento> eventi)
        {
   
            return eventi.Count;
        }

        public static void StampListEvents(List<Evento> eventi)
        {
            foreach (Evento evento in eventi)
            {
                //successivamente prova a stampare la posizione dell'evento all'interno della lista
                Console.WriteLine($"Evento: {evento.title}");
            }
        }

        public static void StampListProgram(string title, List<Evento> eventi)
        {
            Console.WriteLine($"Programma dell'evento: {title}");
            foreach(Evento evento in eventi)
            {
                Console.WriteLine($"    {evento.date} - {evento.title}");
            }
        }
    }


}
