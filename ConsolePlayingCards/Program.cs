﻿using ConsolePlayingCards;

// query syntax
var startingDeck = from s in Suits()
    from r in Ranks()
    select new { Suit = s, Rank = r };

// method syntax
// var startingDeck = Suits()
//     .SelectMany(suit => Ranks()
//         .Select(rank => new { Suit = suit, Rank = rank })
// );

// Display each card that we've generated and placed in startingDeck in the console
foreach (var card in startingDeck)
{
    Console.WriteLine(card);
}

Console.WriteLine();

var top = startingDeck.Take(26);
var bottom = startingDeck.Skip(26);
var shuffle = top.InterleaveSequenceWith(bottom);

foreach (var c in shuffle)
{
    Console.WriteLine(c);
}

return;

static IEnumerable<string> Ranks()
{
    yield return "two";
    yield return "three";
    yield return "four";
    yield return "five";
    yield return "six";
    yield return "seven";
    yield return "eight";
    yield return "nine";
    yield return "ten";
    yield return "jack";
    yield return "queen";
    yield return "king";
    yield return "ace";
}

static IEnumerable<string> Suits()
{
    yield return "clubs";
    yield return "diamonds";
    yield return "hearts";
    yield return "spades";
}