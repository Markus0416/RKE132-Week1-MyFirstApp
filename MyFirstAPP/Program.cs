//This is my a commet to my code 

//rakendus küsib kasutajal sisestada teme nime 
//rakendus tervitab kasutajat nimepidi
Console.WriteLine("Enter yout name: ");

//string - sõne 
string userName = Console.ReadLine();

Console.WriteLine("Hello" + ", " + userName + "!");

//string interpolation
Console.WriteLine($"Hello, {userName} !");