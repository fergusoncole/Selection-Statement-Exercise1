Console.WriteLine("Roll up, Roll up! Don't just stare, please guess my favorite number if you dare!");
//var r = new Random();
//var favNumber = r.Next(10);

var colesFavNumber = 61;
var userInput = int.Parse(Console.ReadLine());
if (userInput < colesFavNumber)
{
    Console.WriteLine("Sorry! That number is too low, try again!");
}
else if (userInput > colesFavNumber) 
{
    Console.WriteLine("Yikes! That number is too high, try again!");
}

else if (userInput == colesFavNumber) 
{ 
    Console.WriteLine("CONGRATULATIONS! How exciting, you guessed it!");
}
else
{
    Console.WriteLine("Sorry, but that's not even close!");
} 

        


