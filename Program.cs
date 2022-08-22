﻿using System;

Console.Write("Choose a difficulty level (e, m, or h): ");
string difficulty = Console.ReadLine().ToLower();

int attemptsLeft = 0;
bool cheater = false;

switch (difficulty)
{
    case "e":
        {
            attemptsLeft = 8;
            break;
        }

    case "m":
        {
            attemptsLeft = 6;
            break;
        }

    case "h":
        {
            attemptsLeft = 4;
            break;
        }

    case "0":
        {
            cheater = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cheater mode enabled!");
            break;
        }
}

Console.Write("Guess a secret number: ");

int secretNumber = new Random().Next(1, 101);

while (attemptsLeft > 0 || cheater)
{
    attemptsLeft--;

    int guessedNumber = int.Parse(Console.ReadLine());

    string highOrLow = (guessedNumber > secretNumber)
    ? "your guess was too high"
    : "your guess was too low";

    string wrongGuess = (attemptsLeft != 0)
    ? $"Sorry {highOrLow}, try again.. You have {(cheater ? "*" : attemptsLeft)} guesses left."
    : $"Sorry, you're all out of tries.\nThe secret number was {secretNumber}";

    bool correct = (guessedNumber == secretNumber);

    string result = (guessedNumber == secretNumber)
    ? "Congratulations! You guessed the secret number!"
    : wrongGuess;

    Console.WriteLine(result);

    if (correct)
        break;
}