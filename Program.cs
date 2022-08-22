using System;

Console.Write("Guess a secret number: ");

int attemptsLeft = 4;

while (attemptsLeft > 0)
{
    attemptsLeft--;

    int guessedNumber = int.Parse(Console.ReadLine());

    int secretNumber = 42;

    string wrongGuess = (attemptsLeft != 0) ? $"Sorry, try again.. You have {attemptsLeft} guesses left." : "Sorry, you're all out of tries.";

    bool correct = (guessedNumber == secretNumber);

    string result = (guessedNumber == secretNumber) ? "Congratulations! You guessed the secret number!" : wrongGuess;

    Console.WriteLine(result);

    if (correct)
        break;
}