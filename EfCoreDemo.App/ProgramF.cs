using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 修改单行记录
    /// 修改之前必须先查询到内存(可以被追踪)
    /// </summary>
    class ProgramF
    {
        static void MainF(string[] args)
        {
            using var context = new DemoContext();

            // 写法一
            //var league = context.Leagues.First();

            //league.Name += "~~";

            //var count = context.SaveChanges();

            // 写法二
            // 适用于查询时数据量比较大且无需追踪的场景
            var league = context.Leagues.AsNoTracking().First();

            league.Name += "++";

            context.Leagues.Update(league); // 此时开始追踪

            var count = context.SaveChanges();

            Console.WriteLine(count);
        }
    }
}
