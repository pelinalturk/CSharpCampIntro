using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleSimulator
{
    interface CampaignService
    {
        void Add(Campaing campaing);

        void Delete(Campaing campaing);

        void ApplyCampaign(Game game, Campaing campaing);
    }
}
