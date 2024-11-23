// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada oma vanus
//kui kasutaja on väiksem kui 13 siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age:");
int userAge = int.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram");
}
else
{
    Console.WriteLine("Not allowed by momma to Instagram!");
}