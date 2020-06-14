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
    class ProgramR
    {
        static void MainR(string[] args)
        {
            // league - club - player
            using var context = new DemoContext();

            // Block1
            //var gamePlayer = new GamePlayer
            //{
            //    GameId = 1,
            //    PlayerId = 4
            //};

            ////context.Add(gamePlayer);
            //context.Remove(gamePlayer);

            // Block2
            //var game = context.Games.First();

            //game.GamePlayers.Add(new GamePlayer
            //{
            //    PlayerId = 4
            //});

            // Block3
            //var player = context.Players.First();

            //player.Resume = new Resume
            //{
            //    Description = "1234"
            //};

            // Block4
            var player = context.Players
                .Include(x => x.Resume)
                .OrderBy(x => x.Id)
                .Last();

            player.Resume = new Resume
            {
                Description = "1894123165489743214"
            };

            context.SaveChanges();

            // Block5
            //var player = context.Players
            //    .AsNoTracking()
            //    .OrderBy(x => x.Id)
            //    .Last();

            //player.Resume = new Resume
            //{
            //    Description = "4321"
            //};

            //{
            //    using var newContext = new DemoContext();
            //    newContext.Attach(player);
            //    newContext.SaveChanges();
            //}
        }
    }
}
