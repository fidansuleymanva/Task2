//Task2: String name dəyişəni təyin edin əgər bu dəyər sizin adınıza bərabərdirsə "Yes" əks halda "No" çap etsin

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Fidan";
            Console.WriteLine("Please enter a name:");
            string inputName = Console.ReadLine();

            if (inputName == name)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

