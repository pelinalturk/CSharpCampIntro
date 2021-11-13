using System;

namespace GameSaleSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer { Name="Pelin"};
            Campaing campaing = new Campaing { CampaignName="Ekim", CampaignAmount=15};
            Game game = new Game { GameName="101 Okey", Price=30};
            GameManager gameManager = new GameManager(new CampaignManager());
            gameManager.Sale(gamer, game, campaing);
        }
    }
}
