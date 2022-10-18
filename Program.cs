//Name: Ulises Ortega
//Date: 09.07.22
//Project Name: Asking Questions
//Description: The program will ask the user questions and stored the answers( user input) and then outputed in the console and ask the user to run the program again yes or no
//Review by:

string userChoice = "";

do{
Console.Clear();
Console.WriteLine("Hi, What is your name");
string myName = Console.ReadLine();
Console.WriteLine("Nice to meet you " + myName);

Console.WriteLine("What time do you woke up");
string userWake = Console.ReadLine();
Console.WriteLine("So your name is " + myName + " and Your woke up at " + userWake);

Console.Clear();
Console.WriteLine("So your name is " + myName + " and You Woke up at " + userWake);

//Console.WriteLine("Thank You for your Input!");

do
{
    Console.WriteLine("Do you want to run the program again Yes or No?");
    userChoice = Console.ReadLine().ToUpper();
    if(userChoice != "YES" && userChoice != "NO")
    {
        Console.WriteLine("Invalid Choice, pLease say Yes or No");
    }
}while (userChoice !="YES" && userChoice != "NO");
}while(userChoice == "YES");


