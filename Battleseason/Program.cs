int battle = 0;
int totalexp = 0;
int exp = 0;
Console.Write("Input your name: ");
string name = Console.ReadLine();

Console.Write("input battle number: ");
int.TryParse(Console.ReadLine(), out battle);

Console.Write("input exp number: ");
int.TryParse(Console.ReadLine(), out exp);

for (int i = 0; i < battle; i++)
{
    Console.WriteLine($"Battle {i + 1} | Exp: {exp} | Total Exp: {totalexp += exp}");
}  

Console.WriteLine("\n== Battle Complete ==");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Total Battles: {battle}");
Console.WriteLine($"Total Experience: {totalexp}");