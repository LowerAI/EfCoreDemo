using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 简单条件查询
    /// </summary>
    class ProgramD
    {
        static void MainD(string[] args)
        {
            using var context = new DemoContext();

            // Country LIKE "%e%"

            // 写法一
            //var leagues = context.Leagues
            //    //.Where(x => x.Country == "Italy")
            //    .Where(x => x.Country.Contains("e"))
            //    .ToList();

            var leagues1 = context.Leagues
                //.Where(x => x.Country == "Italy")
                .Where(x => EF.Functions.Like(x.Country, "%e%"))
                .ToList();

            var first = context.Leagues
                .FirstOrDefault(x => EF.Functions.Like(x.Country, "%e%"));

            var single = context.Leagues
                .SingleOrDefault(x => x.Id == 2);

            var one = context.Leagues.Find(2); // find

            var last = context.Leagues
                //.OrderBy(x => x.Id)
                .OrderByDescending(x => x.Id)
                .LastOrDefault(x => x.Name.Contains("e")); // 使用last必须先排序

            Console.WriteLine(first?.Name);
            Console.WriteLine(single?.Name);
            Console.WriteLine(one?.Name);
            Console.WriteLine(last?.Name);

            // ToList(), First(), FirstOrDefault()
            // Single(), SingleOrDefault(), Last(), LastOrDefault()
            // Count(), LongCount(), Min(), Max(), Average(), Sum()
            // Find()

            // 写法二
            //var leagues2 = (from lg in context.Leagues
            //                where lg.Country == "Italy"
            //                select lg).ToList();
        }
    }
}
