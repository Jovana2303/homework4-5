string sentence = Console.ReadLine();

if (sentence == null)
{
    Console.WriteLine("You entered an empty string.");
}
else
{
    string[] words = sentence.Split(" ");
    foreach (string word in words){
        Console.WriteLine(word);
    }
}