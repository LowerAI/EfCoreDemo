using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 添加关系数据1
    /// 修改之前必须先查询到内存(可以被追踪)
    /// </summary>
    class ProgramH
    {
        static void MainH(string[] args)
        {
            using var context = new DemoContext();

            var serieA = context.Leagues.Single(x => x.Name == "Serie A");

            var juventus = new Club
            {
                League = serieA,
                Name = "Juventus",
                City = "Torino",
                DateOfEstablishment = new DateTime(1987, 11, 1),
                Players = new List<Player>
                {
                    new Player
                    {
                        Name = "C. Ronaldo",
                        DateOfBirth = new DateTime(1985, 2, 5)
                    }
                }
            };

            context.Clubs.Add(juventus);

            int count = context.SaveChanges();

            Console.WriteLine(count);
        }
    }
}
