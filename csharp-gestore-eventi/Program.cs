﻿// See https://aka.ms/new-console-template for more information
using csharp_gestore_eventi;
using System.Collections.Generic;

Console.WriteLine("GestoreEventi");
/*
Console.Write("Inserisci il nome dell'evento: ");
string nome1 = Console.ReadLine();
Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
DateTime data1 = Convert.ToDateTime(Console.ReadLine());
Console.Write("Inserisci il numero di posti: ");
int posti1 = Convert.ToInt32(Console.ReadLine());

Evento evento1 = new Evento(nome1, data1, posti1);
bool askMultipleBooks = false;


Console.Write("Desideri effettuare delle prenotazioni? (s/n) ");
string multipleBooks = Console.ReadLine();


//chiedo all'utente se vuole fare prenotazioni multiple
if (multipleBooks == "s")
{
    askMultipleBooks = true;
    Console.Write("Inserisci il numero di prenotazioni che vuoi effettuare: ");
    int books = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < books; i++)
    {
        Console.Write("Inserisci il numero di posti che vuoi prenotare: ");
        int booksSpots = Convert.ToInt32(Console.ReadLine());
        evento1.BookSpots(booksSpots);
    }
}
else if (multipleBooks == "n")
{
    askMultipleBooks = false;
} else throw new Exception ("risposta non valida");

Console.WriteLine("");

string t = evento1.ToString();
string v = evento1.SpotsReview();
Console.Write(t);
Console.Write(v);

//MILESTONE 2 ------------------------------------------------------------------------------------

//chiedo all'utente se e quanti posti vuole disdire

bool askToDelete = false;  


do
{
    Console.Write("Desideri disdire delle prenotazioni? (s/n) ");
    string multipleDelete = Console.ReadLine();

    if (multipleDelete == "s")
    {
        askMultipleBooks = true;
        Console.Write("Inserisci il numero di posti che vuoi disdire: ");
        int deleteSpots = Convert.ToInt32(Console.ReadLine());
        evento1.DeleteBookedSpots(deleteSpots);
        Console.WriteLine($"Posti prenotati: {evento1.SpotsBooked}");
        Console.WriteLine($"Posti disponibili: { evento1.spotsAviable}");
        Console.WriteLine("");

    }
    else if (multipleDelete == "n")
    {
        askToDelete = false;
        Console.WriteLine("Grazie.");
        break;
    }
    else throw new Exception("risposta non valida");


} while (askToDelete = true);
*/

//MILESTONE 4 ----------------------------------------------------------------------------


Console.Write("Inserisci il nome del tuo programma di eventi: ");
string nameProgramma = Console.ReadLine();
Console.WriteLine("");

ProgrammaEventi programma1 = new ProgrammaEventi(nameProgramma);

Console.Write($"Inserisci il numero di eventi che vuoi aggiungere a {programma1.Title}: ");
int numberEvents = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

for (int i = 0; i < numberEvents; i++)
{
    
    Console.Write("Inserisci il nome dell'evento: ");
    string nome1 = Console.ReadLine();

    Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
    DateTime data1 = Convert.ToDateTime(Console.ReadLine());
    Console.Write("Inserisci il numero di posti: ");
    int posti1 = Convert.ToInt32(Console.ReadLine());
    Evento evento1 = new Evento(nome1, data1, posti1);
    programma1.NewEventInList(evento1);
    Console.WriteLine("");
}

int numberOfEvents = programma1.CountEvents(programma1.Eventi);
Console.WriteLine($"Sono presenti {numberOfEvents} nel tuo programma '{nameProgramma}'");

ProgrammaEventi.StampListProgram(programma1.Title, programma1.Eventi);


bool deleteAllEvents = false;

Console.WriteLine("Vuoi eliminare tutti gli eventi dal tuo programma? (s/n)");
string canDelate = Console.ReadLine();




if (canDelate == "s")
{
    programma1.DeleteAllInList(programma1.Eventi);
    ProgrammaEventi.StampListProgram(programma1.Title, programma1.Eventi);
}
else if (canDelate == "n");
{
    Console.WriteLine("Va bene");
}


Console.WriteLine("");



