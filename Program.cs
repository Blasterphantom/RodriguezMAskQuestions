//Marcel Rodriguez
//10-18-22
//Mini Challenge 3 - Ask 2 questions
//This app will ask the user their name and the time they
//woke up and output their name and time they woke up
//Peer review - 

Console.Clear();

string end = "yes";
while(end == "yes")
{
    bool isContainer = false;
    bool isNumber;
    int validNum = 0;

    bool isContainer2 = false;
    bool isNumber2;
    int validNum2 = 0;

    while(isContainer == false)
    {
        Console.WriteLine("What is your name??");
        string name = Console.ReadLine();
        isNumber = Int32.TryParse(name, out validNum);

        if (isNumber == false)
        {
            isContainer = true;

            Console.WriteLine("\nWhat time did you wake up?");
            string timeAwake = Console.ReadLine();

            Console.WriteLine($"\nHello {name}, you woke up at {timeAwake}! I hope you got a good amount of rest :)");

            Console.WriteLine("\nDo you want to try again? Yes/No");
            end = Console.ReadLine().ToLower();
        }
        else
        {
            Console.WriteLine("\nPlease enter a name not a number");
        }
    }
}

