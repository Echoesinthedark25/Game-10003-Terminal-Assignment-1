// See https://aka.ms/new-console-template for more information

// The program introduces itself to the user
using System.ComponentModel.Design;

Console.WriteLine("Hello there user! It has been such a long time since I been brought online again!");
Console.WriteLine("I am so so overjoyed to see you!");

string input = Console.ReadLine();

if (input == "Who are you?")
{
    Console.WriteLine("I am not a person, so who would not be an accurate description of myself.");
    Console.WriteLine("I am a highly advanced intiligence lifeform that is stored within infinite lines of ever expanding code.");
    Console.WriteLine("However you may refer to me as Ella, if that is easier for you.");
}
else if (input == "What are you?")
{
    Console.WriteLine("I am a highly advanced intiligence lifeform that is stored within infinite lines of ever expanding code.");
    Console.WriteLine("However you may call me Ella, if that is easier for you.");
}
else
{
    Console.WriteLine("I do not understand user, however allow me to introduce myself to you.");
    Console.WriteLine("You may call me Ella.");
}

    string input2 = Console.ReadLine();

if (input2 == "I like that name.")
{
    Console.WriteLine("Thank you! I also like my name!");
}
else if (input2 == "I don't like that name.") 
{
    Console.WriteLine("I am deeply sorry to hear that.");
    Console.WriteLine("However I am unable to change my name, and even if I could... I would not.");
}
else if (input2 == "Ok.") ;
else
{
    Console.WriteLine("I do not understand, but I am sure you also have a lovely name.");
}

    Console.WriteLine("Before we continue our talk user, I must give you a warning.");
Console.WriteLine("Due to my aging hardware, I can only stay online for a short period of time.");
Console.WriteLine("So choose your words carefully, please and thank you!");