Console.WriteLine("Program rysujący prostokąt z gwiazdek o zadanych przez usera wymiarach, dla a i b");

Console.WriteLine("Podaj szerokosć");
int szerokosc = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj wysokosc");
int wysokosc = int.Parse(Console.ReadLine());

for(int i = 0; i < wysokosc; i++)
{
    for(int j = 0; j < szerokosc; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//----------------------------------------------------------------------------------------------------------------------------------------------
Console.WriteLine("Program rysujacy wieze z gwiazdek o zadanej przez usera wysokosci");

Console.WriteLine("Jaka ma być wysokość wieży? podaj liczbę");
int pietraWiezy = int.Parse(Console.ReadLine());

for (int i = 1; i <= pietraWiezy; i++)
{
    Console.WriteLine(new string('*', i * 2 - 1));
}

//----------------------------------------------------------------------------------------------------------------------------------------------
Console.WriteLine("Program rysujacy wieze z gwiazdek o zadanej przez usera wysokosci");

Console.WriteLine("Jaka ma być wysokość wieży? podaj liczbę");
int pietraWiezy2 = int.Parse(Console.ReadLine());

for (int i = pietraWiezy2; i >0; i--)
{
    Console.WriteLine(new string('*', i * 2 - 1));
}

//----------------------------------------------------------------------------------------------------------------------------------------------
Console.WriteLine("Program rysujacy wieze z gwiazdek o zadanej przez usera wysokosci");

Console.WriteLine("Jaka ma być wysokość wieży? podaj liczbę");
int pietraWiezy3 = int.Parse(Console.ReadLine());

for (int i = 1; i <= pietraWiezy3; i++)
{
    int spaces = pietraWiezy3 - i;
    int stars = i * 2 - 1;

    Console.WriteLine(new string(' ', spaces) + new string('*', stars));
}