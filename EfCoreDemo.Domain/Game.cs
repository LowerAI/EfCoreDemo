using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreDemo.Domain
{
    /// <summary>
    /// 比赛
    /// </summary>
    public class Game
    {
        public Game()
        {
            GamePlayers = new List<GamePlayer>();
        }

        public int Id { get; set; }
        /// <summary>
        /// 第几轮
        /// </summary>
        public int Round { get; set; }
        public DateTimeOffset? StartTime { get; set; }

        public List<GamePlayer> GamePlayers { get; set; }
    }
}
