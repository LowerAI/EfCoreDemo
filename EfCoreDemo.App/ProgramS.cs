using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 执行原生SQL1
    /// </summary>
    class ProgramS
    {
        static void MainS(string[] args)
        {
            using var context = new DemoContext();

            //var playerClubs = context.PlayerClubs
            //    .Where(x => x.PlayerId > 1)
            //    .ToList();

            //var leagues = context.Leagues
            //    .FromSqlRaw("SELECT * FROM dbo.Leagues")
            //    .ToList();

            //var clubs = context.Clubs
            //    .FromSqlRaw("SELECT * FROM dbo.Clubs")
            //    .Include(x => x.League)
            //    .Include(x => x.Players)
            //        .ThenInclude(x => x.GamePlayers)
            //    .ToList();

            var clubs = context.Clubs
                .FromSqlInterpolated($"SELECT * FROM dbo.Clubs WHERE Id > {0}")
                .ToList();
        }
    }
}
