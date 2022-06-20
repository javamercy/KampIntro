using GamerDemo.Abstract;
using GamerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerDemo.Concrete
{
    public class SaleManager : ISaleService
    {
        ICampaignService _campaignService;

        public SaleManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Sale(Gamer gamer)
        {

            Console.WriteLine("Game has been sold to " + gamer.Nickname + ".");

            foreach (var campaign in _campaignService.GetCampaigns())
            {
                Console.WriteLine(campaign.Name);
            }
        }
    }
}
