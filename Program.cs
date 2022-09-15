// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibiPrefe = { "Nutella", "Tiramisù", "Pizza", "Gelato", "Panini", "Patatine Fritte", "Panzerotti", "Parmigiana"};


Console.WriteLine("Ho "+ cibiPrefe.Length + " cibi preferiti");

Console.WriteLine("E questa è la classifica:");

for (int i = 0; i < cibiPrefe.Length; i++)
{
    Console.WriteLine(i + 1 + ") " + cibiPrefe[i]);
}

Console.WriteLine("Il mio cibo preferito è " + cibiPrefe[0]);
Console.WriteLine("Il mio cibo non troppo preferito è " + cibiPrefe[cibiPrefe.Length - 1]);

