using System;

Console.Write("Guess a secret number: ");

int attemptsLeft = 4;

int secretNumber = new Random().Next(1, 101);

while (attemptsLeft > 0)
{
    attemptsLeft--;

    int guessedNumber = int.Parse(Console.ReadLine());

    string highOrLow = (guessedNumber > secretNumber)
    ? "your guess was too high"
    : "your guess was too low";

    string wrongGuess = (attemptsLeft != 0)
    ? $"Sorry {highOrLow}, try again.. You have {attemptsLeft} guesses left."
    : $"Sorry, you're all out of tries.\nThe secret number was {secretNumber}";

    bool correct = (guessedNumber == secretNumber);

    string result = (guessedNumber == secretNumber)
    ? "Congratulations! You guessed the secret number!"
    : wrongGuess;

    Console.WriteLine(result);

    if (correct)
        break;
}