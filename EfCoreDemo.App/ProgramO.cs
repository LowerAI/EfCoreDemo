using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 加载关联数据4
    /// 预加载，Eager loading
    /// 显示加载，、Explicit loading
    /// 懒加载，lazy loading
    /// </summary>
    class ProgramO
    {
        static void MainO(string[] args)
        {
            // league - club - player
            using var context = new DemoContext();

            // player -- gameplayer -- game
            var gamePlayers = context
                .Set<GamePlayer>()
                .Where(x => x.Player.Id > 0)
                .ToList();
        }
    }
}
