// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

public class Utility 
{
    LinkedList linkedList = new LinkedList();
    DeckOfCards cards = new DeckOfCards();
    private int[,] deckOfcards = new int[4, 13];

    /// <summary>
    /// The random
    /// </summary>
    private Random random = new Random();

    /// <summary>
    /// The player
    /// </summary>
    private int player = 1;

    /// <summary>
    /// Gets the suit.
    /// </summary>
    /// <param name="suits">The suits.</param>
    /// <returns> returns suit</returns>

    public static string GetSuit(int suits)
    {
        switch (suits)
        {
            case 0:
                {
                    return "clubs";
                }

            case 1:
                {
                    return "Diamond";
                }

            case 2:
                {
                    return "Heart";
                }

            case 3:
                {
                    return "Spade";
                }

            default:
                {
                    return "In switch (default)";
                }
        }
    }

    /// <summary>
    /// Gets the rank.
    /// </summary>
    /// <param name="rank">The rank.</param>
    /// <returns> returns rank</returns>
    public static string GetRank(int rank)
    {
        switch (rank)
        {
            case 0:
                {
                    return "2";
                }

            case 1:
                {
                    return "3";
                }

            case 2:
                {
                    return "4";
                }

            case 3:
                {
                    return "5";
                }

            case 4:
                {
                    return "6";
                }

            case 5:
                {
                    return "7";
                }

            case 6:
                {
                    return "8";
                }

            case 7:
                {
                    return "9";
                }

            case 8:
                {
                    return "10";
                }

            case 9:
                {
                    return "Jack";
                }

            case 10:
                {
                    return "Queen";
                }

            case 11:
                {
                    return "King";
                }

            case 12:
                {
                    return "Ace";
                }

            default:
                {
                    return string.Empty;
                }
        }
    }

    /// <summary>
    /// Initializes the deck of cards.
    /// </summary>
    public void InitializeDeckOfCards()
    {
        ////loops 1 time for all 4 players.
        for (int playerNumber = 1; playerNumber <= 4; playerNumber++)
        {
            this.Distribute9Cards(playerNumber);
            this.player++;
            Console.WriteLine("=============");
            this.Print(playerNumber);
            Console.WriteLine("==============");
        }
    }

    /// <summary>
    /// Distribute9s the cards.
    /// </summary>
    /// <param name="playerNumber">The player number.</param>
    public void Distribute9Cards(int playerNumber)
    {
        //// loops 9 times for each player so as to give 9 cards to each
        for (int i = 0; i < 9; i++)
        {
            this.ShuffleCards(playerNumber);
            
        }
    }

    /// <summary>
    /// Shuffles the cards.
    /// </summary>
    /// <param name="playerNumber">The player number.</param>
    public void ShuffleCards(int playerNumber)
    {
        ////generating a random Number for suit.
        int suit = this.random.Next(1, 4);
        ////generating a random Number for rank.
        int rank = this.random.Next(1, 13);
        if (this.deckOfcards[suit, rank] == 0)
        {
            this.deckOfcards[suit, rank] = playerNumber;
            return;
        }
        else
        {
            this.ShuffleCards(playerNumber);
        }
    }

    /// <summary>
    /// Prints the specified player number.
    /// </summary>
    /// <param name="playerNumber">The player number.</param>
    public void Print(int playerNumber)
    {
        int suitLength = this.deckOfcards.GetLength(0);
        int rankLength = this.deckOfcards.GetLength(1);
        for (int suits = 0; suits < suitLength; suits++)
        {
            for (int ranks = 0; ranks < rankLength; ranks++)
            {
                if (this.deckOfcards[suits, ranks] == playerNumber)
                {
                    Console.WriteLine(GetSuit(suits) + " " + GetRank(ranks));
                }
            }
        }
    }

}
