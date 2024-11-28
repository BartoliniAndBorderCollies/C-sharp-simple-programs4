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

//-----------------------------------------------------------------------------------------------------------------------------------------------
Console.WriteLine("Program sprawdzający czy podana liczba jest liczbą pierwszą");

Console.WriteLine("Podaj liczbę: ");

int answer = int.Parse(Console.ReadLine());

bool isPrime(int answer)
{

    if(answer <=1)
    {
        return false;
    }
    if (answer == 2)
    {
        return true;
    }

    if(answer % 2 == 0)
    {
        return false;
    }

    for (int i = 3; i <= Math.Sqrt(answer); i += 2)
    {
        if (answer % i == 0)
        {
            return false;
        }
    }
    return true;
}
if (isPrime(answer))
    Console.WriteLine($"Podana liczba {answer} jest liczbą pierwszą!");
else Console.WriteLine("Podana liczba nie jest liczba pierwszą!");