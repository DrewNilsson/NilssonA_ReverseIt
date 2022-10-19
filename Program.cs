// Andrew Nilsson
// 09-14-2022
// Mini Challenge #7 - Reverse It
// This is a console project that will 
// Peer Review by: Ken because we cant have a breach in my teaching


Console.Clear();


bool loop = true;
while (loop)
{
    string? input = "";

    Console.WriteLine("Enter a number or word");
    input = Console.ReadLine();

    // Declares a char array and initializes it by converting the string input using ToCharArray method
    char[] nameArray = input.ToCharArray();
    // Reverse method for arrays
    Array.Reverse(nameArray);
    // Declares a string and initializes it with the reversed array
    string reverseString = new string(nameArray);

    Console.WriteLine(reverseString);


    Console.WriteLine("Would you like to try again? Yes or No?");

    bool loopInputValid = false;
    while (!loopInputValid)
    {
        string loopInput = Console.ReadLine().ToLower();

        if (loopInput == "yes") 
        {
            loopInputValid = true;
        }
        else if (loopInput == "no") 
        {
            loopInputValid = true; 
            loop = false; 
            Console.WriteLine("Have a great day!");
        }
        else Console.WriteLine("INVALID INPUT\nEnter Yes or No");
        
    }
}