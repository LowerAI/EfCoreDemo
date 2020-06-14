using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 修改关联数据2
    /// </summary>
    class ProgramQ
    {
        static void MainQ(string[] args)
        {
            // league - club - player
            using var context = new DemoContext();

            var game = context.Games
                .Include(x => x.GamePlayers)
                    .ThenInclude(x => x.Player)
                .First();

            var firstPlayer = game.GamePlayers[0].Player;
            firstPlayer.Name += "$";

            {
                using var newContext = new DemoContext();
                //newContext.Players.Update(firstPlayer); // 此时会造成关联更新
                newContext.Entry(firstPlayer).State = EntityState.Modified;
                newContext.SaveChanges();
            }
        }
    }
}
