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