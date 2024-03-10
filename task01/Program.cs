string s = Console.ReadLine();

if (s.Length > 5)
{
    string cutted = s.Substring(s.Length-5);
    Console.WriteLine(cutted);
}
else
{
    Console.WriteLine("Wrong input");
}