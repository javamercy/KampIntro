using GamerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerDemo.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);

        void Update(Gamer gamer);

        void Delete(Gamer gamer);
    }
}
