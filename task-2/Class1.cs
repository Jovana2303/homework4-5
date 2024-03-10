using Classes;

namespace Classes
{
    public class Dog
    {
        public string name { get; set; }
        public string breed { get; set; }
        public string color { get; set; }

        public void Eat() {
            Console.WriteLine("The dog is now eating.");
        }
        public void Play()
        {
            Console.WriteLine("The dog is now playing.");
        }
        public void ChaseTail()
        {
            Console.WriteLine("Dog is now chasing its tail.");
        }

    }

}
class Program
{
    static void Main(string[] args){

        string name, breed, color;
        int option;

        Console.Write("Enter your dog's name: ");
        name = Console.ReadLine();
        Console.Write("Enter your dog's breed: ");
        breed = Console.ReadLine();
        Console.Write("Enter your dog's color: ");
        color = Console.ReadLine();

        Dog dog = new Dog();
        dog.name = name;
        dog.breed = breed;
        dog.color = color;

        Console.Write("What is your dog doing: ");
        bool success = int.TryParse(Console.ReadLine(), out option);

        if (success)
        {
            if(option == 1)
            {
                dog.Eat();
            }
            else if(option == 2){
                dog.Play();
            }
            else if(option == 3)
            {
                dog.ChaseTail();
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }
}