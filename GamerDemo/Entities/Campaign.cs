using GamerDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerDemo.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double DiscountRate { get; set; }

        public DateTime ExpiringDate { get; set; }
    }
}
