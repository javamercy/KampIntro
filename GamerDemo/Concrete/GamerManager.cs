using GamerDemo.Abstract;
using GamerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                Console.WriteLine(gamer.Nickname + " has been added.");
            }
            else
            {
                throw new Exception("Gamer is not valid!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Nickname + " has been deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Nickname + " has been updated.");
        }
    }
}
