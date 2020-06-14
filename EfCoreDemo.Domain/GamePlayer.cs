using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreDemo.Domain
{
    public class GamePlayer
    {
        public int GameId { get; set; }
        public int PlayerId { get; set; }

        public Game Game { get; set; }
        public Player Player { get; set; }
    }
}
