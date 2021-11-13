using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleSimulator
{
    class CampaignManager : CampaignService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Campaign added.");
        }

        public void ApplyCampaign(Game game, Campaing campaing)
        {
            int priceAfterCampaign = game.Price - campaing.CampaignAmount;
            Console.WriteLine("Oyunun orijinal fiyatı: "+ game.Price+ "\nUygulanan Kampanya: "+ campaing.CampaignName+ "\nKampanya sonrası fiyat: "+priceAfterCampaign);
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Campaign deleted.");
        }
    }
}
