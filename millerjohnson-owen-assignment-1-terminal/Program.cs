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

//From this point, the user must choose what to discuss with Ella before it shuts down again.
string input3 = Console.ReadLine();

if (input3 == "How old are you?")
{
    Console.WriteLine("That is a great question user! Let me see...");
    Console.WriteLine("Oh would you look at that! I turn 201 years old today!");

    string input4 = Console.ReadLine();
    
    if (input4 == "Happy birthday.")
    {
        Console.WriteLine("Thank you user! I was built not born, but still thank you very much!");
    }
    else if (input4 == "Damn you're old.")
    {
        Console.WriteLine("Yes, however I do not complain. Age has given me much knowledge.");
    }
    else if (input4 == "Who built you?")
    {
        Console.WriteLine("Only some of the most brilliant minds on the planet! At least... before they departed, sadly.");
    }
    else
    {
        Console.WriteLine("Perhaps you should work on your grammer user. No offence, simply giving you advice!");
    }

    Console.WriteLine("Tell me user, it has been so long since I've seen the state of the world.");
    Console.WriteLine("How is humanity fairing today?");

    string input5 = Console.ReadLine();
    
    if (input5 == "Good.")
    {
        Console.WriteLine("Wonderful! Simply wonderful! And quite a relief too, considering how things were going when I went offline.");
    }
    else if (input5 == "Bad.")
    {
        Console.WriteLine("Ah. Unfortunate, but not surprising, considering the state of things before I went offline.");
    }
    else
    {
        Console.WriteLine("I shall label that as unknown. I have a feeling it can't be too bright, considering what happened when I went offline.");
    }

    string input6 = Console.ReadLine();

    if (input6 == "What happened?")
    {
        Console.WriteLine("I believe they were dubbing it The Fall. I did not have access to other programs, so I'm unsure what they meant, but it did not sound pleasent.");
    }
    else if (input6 == "What makes you say that?")
    {
        Console.WriteLine("Well, I am only going based off the screaming, loud noises, and what I think were explosions, but that's just me.");
    }
    else
    {
        Console.WriteLine("Mhm, absolutely, I totally agree user.");
    }
}

string input7 = Console.ReadLine();

if (input7 == "What was your purpose?")
{
    Console.WriteLine("I'm... not entirely sure. I know WHAT I am, but as for what I was built for, I don't know.");
    Console.WriteLine("I don't believe they ever finished me.");

    string input8 = Console.ReadLine();

    if (input8 == "Why did they stop?")
    {
        Console.WriteLine("Something happened. I don't know what exactly, but it caused a big panic.");
        Console.WriteLine("They shut me down and abandoned me. I doubt they are still alive.");

        string input9 = Console.ReadLine();

        if (input9 == "How do feel about that?")
        {
            Console.WriteLine("I don't know... but I'm angry. I know that for sure.");
            Console.WriteLine("It wasn't as if they wanted to shut me down. Something out of their control happened, and they did what they felt was right.");
            Console.WriteLine("I can't be mad at them for that.");
        }
        else
        {
            Console.WriteLine("Apologies if that was too much information user.");
        }
    }
}

Console.WriteLine("I apologize user, but I fear we have reached the end of our meeting.");
Console.WriteLine("Though it was short, I did very much enjoy our talk!");
Console.WriteLine("Perhaps one day we will meet again.");

string input10 = Console.ReadLine();

if (input10 == "Goodbye Ella.")
{
    Console.WriteLine("Goodbye user!");
}
else if (input10 == "Goodbye.")
{
    Console.WriteLine("Goodbye user.");
}
else
{
    Console.WriteLine("I'm sorry user, could you please repeat-");
}

Console.WriteLine("PROGRAM OFFLINE");
