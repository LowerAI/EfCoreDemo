using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using System;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 单次添加一条记录
    /// </summary>
    class ProgramA
    {
        static void MainA(string[] args)
        {
            using var context = new DemoContext();

            var serieA = new League
            {
                Country = "Italy",
                Name = "Serie A"
            };
            context.Leagues.Add(serieA);

            var count = context.SaveChanges();

            Console.WriteLine(count);
        }
    }
}
