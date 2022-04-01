// See https://aka.ms/new-console-template for more information

// Cibi messi in ordine di gradimento
string[] cibo = { "Carbonara", "Pollo Fritto", "Tiramisù", "Cacio e Pepe", "Frittura di pesce", "Babà", "Pizza Margherita" };
Console.WriteLine();

Console.WriteLine("I miei cibi preferiti sono:" + cibo.Length);
for(int i = 0; i < cibo.Length; i++)
{
    Console.WriteLine($"Al {i + 1}° posto : {cibo[i]}");
}

// Classifica Prima ed Ultima 
var primaPosizione = cibo[0];
var ultimaPosizione = cibo[cibo.Length - 1];
Console.WriteLine("Questo è il mio cibo preferito : " + primaPosizione);
Console.WriteLine("Questo è quello che preferisco meno : " + ultimaPosizione);

// Mediana con cibi pari e dispari

var mediana = cibo[cibo.Length / 2];
var medianapari = cibo[(cibo.Length / 2) - 1];

if (cibo.Length % 2 == 0)
{
  Console.WriteLine($"A metà classifica: {mediana} e {medianapari}");
}

else
{
  Console.WriteLine($"A metà classifica: {mediana}");
}

    //FINE