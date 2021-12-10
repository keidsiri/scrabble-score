using System;
using System.Collections.Generic;
using ScrabbleScore.Models;  //import namespaces from Letter.cs


namespace ScrabbleGame
{
class Program
{
  static void Main()
  {
    Console.WriteLine("Enter a word to see its score");
    string userInput = Console.ReadLine();
    Console.WriteLine("______________________________");
    
    Score totalScore = new Score(userInput);
    int result = totalScore.CountScore();
    Console.WriteLine($"Your score is {result}");
  }
}
}

