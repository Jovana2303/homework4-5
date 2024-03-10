int sumOfDigits(int number)
{
    int sum = 0;

    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}

int number;
Console.Write("Enter a number: ");
bool success = int.TryParse(Console.ReadLine(), out number);

if (success)
{
    int result = sumOfDigits(number);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Wrong input");
}
Console.Write("Enter a sentence: ");
string sentence = Console.ReadLine();
string longestWord = "";

if (sentence == null)
{
    Console.WriteLine("You entered an empty string.");
}
else
{
    string[] words = sentence.Split(" ");
    foreach (string word in words){
        if(longestWord.Length < word.Length)
        {
            longestWord = word;
        }
    }
    Console.WriteLine("The longest word is: " + longestWord);
}