using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 批量插入多条记录到各自对应的表
    /// </summary>
    class ProgramC
    {
        static void MainC(string[] args)
        {
            using var context = new DemoContext();

            var serieA = context.Leagues.Single(x => x.Name == "Serie A");

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

            var milan = new Club
            {
                Name = "AC milan",
                City = "Milan",
                DateOfEstablishment = new DateTime(1899, 12, 16),
                League = serieA
            };

            context.AddRange(serieB, serieC, milan);

            var count = context.SaveChanges();

            Console.WriteLine(count);
        }
    }
}
