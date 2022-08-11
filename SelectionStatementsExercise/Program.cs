////Exercise 1
var r = new Random();
var favNumber = r.Next(1, 1000);
Console.WriteLine("Try to guess my favorite number");
var userInput = int.Parse(Console.ReadLine());

if (favNumber < userInput)
{
    Console.WriteLine($"{userInput} Is too low");
}

else if (favNumber > userInput)
{
    Console.WriteLine($"{userInput} Is too high");
}
else
{
    Console.WriteLine("Nevermind");
}

//Exercise 2

Console.WriteLine("What is  your favorite school subject");
    var subject = Console.ReadLine();


 switch(subject)
{ case "Math":
        Console.WriteLine("Math is a tough Subject");
        break;

    case "Science":
        Console.WriteLine("Science is awesome!");
        break;

    case "English":
        Console.WriteLine($"I struggled with {subject} when I was younger because my family spoke spanish growing up.");
        break;
    
    
    default:
        Console.WriteLine($"wow! I have never done {subject} before! Awesome!");
        break;

        






}        






    
            
    






