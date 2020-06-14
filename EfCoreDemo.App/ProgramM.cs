using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 加载关联数据2
    /// 预加载，Eager loading
    /// 显示加载，、Explicit loading
    /// 懒加载，lazy loading
    /// </summary>
    class ProgramM
    {
        static void MainM(string[] args)
        {
            // league - club - player
            using var context = new DemoContext();

            var info = context.Clubs
                .Where(x => x.Id > 0)
                .Select(x => new
                {
                    x.Id,
                    LeagueName = x.League.Name,
                    x.Name,
                    Players = x.Players
                        .Where(p => p.DateOfBirth > new DateTime(1990, 1, 1))
                }).ToList();
            // Context 无法追踪匿名类(在Context中未注册)，只能追踪它识别的类(在Context中已注册)

            foreach (var data in info)
            {
                foreach (var player in data.Players)
                {
                    player.Name += "~";
                }
            }

            context.SaveChanges();
        }
    }
}
