using System;
using System.Collections.Generic;


namespace MyGame
{

    class Program
    {
        static void Main()
        {

            Game standardGame = GameFactory.CreateStandardGame();
            Game trainingGame = GameFactory.CreateTrainingGame();
            Game singlePlayerGame = GameFactory.CreateSinglePlayerGame();

            GameAccount player1 = new GameAccount("Pipipypy", 1250, new Warrior());
            GameAccount player2 = new GameAccount("Pog", 1600, new Assassin());
            GameAccount player3 = new GameAccount("Frog", 1000, new HollowKnight());

            player1.WinGame("Martins", standardGame);
            player1.LoseGame("Kerbal", standardGame);
            player1.WinGame("abc2008", standardGame);
            player1.WinGame("help", trainingGame);
            player1.WinGame("Botik", singlePlayerGame);


            player2.WinGame("Obama", standardGame);
            player2.LoseGame("Badin", standardGame);
            player2.WinGame("Botik", singlePlayerGame);
            player2.WinGame("Jerb", trainingGame);
            player2.LoseGame("Boba", trainingGame);

            player3.WinGame("Bob228", standardGame);
            player3.WinGame("Botik", singlePlayerGame);
            player3.WinGame("Kotik", singlePlayerGame);
            player3.LoseGame("Cito", standardGame);
            player3.WinGame("Pants", standardGame);

            player1.GetStats();
            player2.GetStats();
            player3.GetStats();

        }
    }
}