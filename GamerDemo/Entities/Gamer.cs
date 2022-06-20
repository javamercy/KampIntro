using GamerDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerDemo.Entities
{
    public class Gamer : IEntity
    {
        public int Id { get; set; }

        public string Nickname { get; set; }

        public string GamingExperience { get; set; }

        public DateTime DateOfBirth { get; set; }


    }
}
