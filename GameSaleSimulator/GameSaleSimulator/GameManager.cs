using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleSimulator
{
    class GameManager : GameService
    {
        CampaignService campaignService;
        public GameManager(CampaignService _campaignService)
        {
            campaignService = _campaignService;
        }
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+ " isimli oyun eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " isimli oyun silindi.");
        }

        public void Sale(Gamer gamer, Game game, Campaing campaing)
        {
            Console.WriteLine(game.GameName + " oyunu " + gamer.Name + " isimli oyuncuya satıldı.");
            campaignService.ApplyCampaign(game,campaing);
        }
    }
}
