using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreDemo.Domain
{
    public class PlayerClub
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string ClubName { get; set; }
    }
}
