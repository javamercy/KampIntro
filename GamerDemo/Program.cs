using GamerDemo.Abstract;
using GamerDemo.Adapters;
using GamerDemo.Concrete;
using GamerDemo.Entities;
using System;

namespace GamerDemo
{
    class Program
    {
        public static object ISaleSerice { get; private set; }

        static void Main(string[] args)
        {
            IGamerService gamerManager = new GamerManager(new GamerCheckAdapter());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                Nickname = "Warmachine",
                DateOfBirth = new DateTime(2001, 7, 10),
                GamingExperience = "Impossible"
            });

            ISaleService saleSerice = new SaleManager(new CampaignManager());
            saleSerice.Sale(new Gamer
            {
                Id = 1,
                Nickname = "Warmachine",
                DateOfBirth = new DateTime(2001, 7, 10),
                GamingExperience = "Impossible"
            });
        }
    }
}
