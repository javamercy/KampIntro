using GamerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerDemo.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealGamer(Gamer gamer);
    }
}
