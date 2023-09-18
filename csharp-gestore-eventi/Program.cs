﻿// See https://aka.ms/new-console-template for more information
using csharp_gestore_eventi;

Console.WriteLine("GestoreEventi");

Console.Write("Inserisci il nome dell'evento: ");
string nome1 = Console.ReadLine();
Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
DateTime data1 = Convert.ToDateTime(Console.ReadLine());
Console.Write("Inserisci il numero di posti: ");
int posti1 = Convert.ToInt32(Console.ReadLine());

Evento evento1 = new Evento(nome1, data1, posti1);

Console.Write("Quanti posti desideri prenotare? ");
int prenotati1 = Convert.ToInt32(Console.ReadLine());
evento1.BookSpots(prenotati1);

Console.WriteLine("");

string t = evento1.ToString();
string v = evento1.SpotsReview();
Console.Write(t);
Console.Write(v);

