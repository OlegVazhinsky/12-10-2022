Console.Write("Please enter your name -> ");
string userName = Console.ReadLine();
if (userName.ToLower() == "oleg") {
    Console.WriteLine("Horay! It is Oleg!");
} else {
    Console.WriteLine("Hello, " + userName);
}