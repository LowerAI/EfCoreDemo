using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using System;
using System.Collections.Generic;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 批量插入两条记录到单表
    /// </summary>
    class ProgramB
    {
        static void MainB(string[] args)
        {
            using var context = new DemoContext();

            var serieB = new League
            {
                Country = "Italy",
                Name = "Serie B"
            };
            var serieC = new League
            {
                Country = "Italy",
                Name = "Serie C"
            };

            context.Leagues.AddRange(serieB, serieC); // 写法一
            //context.Leagues.AddRange(new List<League> { serieB, serieC }); // 写法二

            var count = context.SaveChanges();

            Console.WriteLine(count);
        }
    }
}
