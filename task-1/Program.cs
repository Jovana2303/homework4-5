int CalculateAge(DateTime dateOfBirth){
    DateTime today = DateTime.Now;
    int age;
    age = today.Year - dateOfBirth.Year;
    if(today.Month < dateOfBirth.Month || (today.Month == dateOfBirth.Month && today.Day < dateOfBirth.Day))
    {
        --age;
    }
    return age;
}

DateTime dateOfBirth;
Console.Write("Enter your date of birth: ");
bool success = DateTime.TryParse(Console.ReadLine(), out dateOfBirth);
int yourAge = 0;

if (success)
{
    yourAge = CalculateAge(dateOfBirth);
    Console.WriteLine("You are " + yourAge + " old");
}
else
{
    Console.WriteLine("Wrong input");
}