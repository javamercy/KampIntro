using GamerDemo.Abstract;
using GamerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " has been added.");
        }

        public void Delete(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public List<Campaign> GetCampaigns()
        {
            return new List<Campaign>
            {
                new Campaign{Id =1, Name = "Şahane Cuma",DiscountRate =50, ExpiringDate = new DateTime(2022)},

                 new Campaign{Id =2, Name = "Trendyol Zamanı",DiscountRate =35, ExpiringDate = new DateTime(2023)}
            };
        }

        public void Update(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
