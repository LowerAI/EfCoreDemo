using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 加载关联数据1
    /// 预加载，Eager loading
    /// 显示加载，、Explicit loading
    /// 懒加载，lazy loading
    /// </summary>
    class ProgramK
    {
        static void MainK(string[] args)
        {
            // league - club - player
            using var context = new DemoContext();

            var club = context.Clubs
                .Where(x => x.Id > 0)
                .Include(x => x.League)
                .Include(x => x.Players)
                    .ThenInclude(y => y.Resume)
                .Include(x => x.Players)
                    .ThenInclude(y => y.GamePlayers)
                        .ThenInclude(z => z.Game)
                .FirstOrDefault();
        }
    }
}
