using GamerDemo.Abstract;
using GamerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerDemo.Adapters
{
    public class GamerCheckAdapter : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            Gamer _gamer = new Gamer
            {
                Id = 1,
                Nickname = "Warmachine",
                DateOfBirth = new DateTime(2001, 7, 10),
                GamingExperience = "Impossible"
            };

            if (_gamer.Nickname == gamer.Nickname)
            {
                return true;
            }

            return false;
        }
    }
}
