Random random = new Random();
char[] symbols = new char[random.Next(4, 4)];
for (int i = 0; i < symbols.Length; i++)
{
    Console.WriteLine(symbols[i] + " ");
}
int star = 0; 
int semicolon = 0;
int colon = 0;

foreach (char symbol in symbols)
{
    if (symbol == '*')
        star++;
    else if (symbol == ';')
        semicolon++;
    else if (symbol == ':')
        colon++;
}
Console.WriteLine("Количество символов *: " + star);
Console.WriteLine("Количество символов ;: " + semicolon);
Console.WriteLine("Количество символов :: " + colon);