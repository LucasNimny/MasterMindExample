////////////////////////////////////////////////
// Master Mind Example for Quadax
// Created by Tyler Skipper
// Created on 1/25/2023
////////////////////////////////////////////////

using MastermindExample.Classes;

int attempts = 0;
DigitManager digitManager = new();

Console.WriteLine($"Master Mind Example Program\n4 digits are drawn at random\nEnter a 4 digit numerical value between 1 through 6 and guess what the combination is!\n");
Console.WriteLine($"[+] means that the digit is in the correct spot and is accurate\n[-] means that the digit io accurate but in the incorrect spot");

do
{
    Console.WriteLine($"\nAttempt {attempts + 1}: Enter 4 numbers");
    string? userResult = Console.ReadLine();

    if (string.IsNullOrEmpty(userResult) || userResult.Length != 4)
    {
        Console.WriteLine("Invalid input entered");
        continue;
    }

    UserDigit[] userDigits = new UserDigit[4];

    bool userValid = true;
    for(int i = 0; i < userResult.Length; i++)
    {
        UserDigit userDigit = new UserDigit();

        try
        {
            userDigit.GivenDigit = int.Parse(userResult.Substring(i, 1));
            if(userDigit.GivenDigit > 6)
            {
                Console.WriteLine("Digit outside of range");
                userValid = false;
                break;
            }
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Invalid Digit found.");
            userValid = false;
            break;
        }

        userDigits[i] = userDigit;
    }

    if(userValid)
    {
        Console.WriteLine(digitManager.CheckInput(ref userDigits));
        attempts++;
    }

}
while (attempts < 10 && !digitManager.won);

if(digitManager.won)
{
    Console.WriteLine("\nYou won!");
}
else
{
    Console.WriteLine("\nBetter luck next time!");
}

