using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 修改多行记录
    /// 修改之前必须先查询到内存(可以被追踪)
    /// </summary>
    class ProgramG
    {
        static void MainG(string[] args)
        {
            using var context = new DemoContext();

            var leagues = context.Leagues.Skip(1).Take(2).ToList();

            foreach (var league in leagues)
            {
                league.Name += "~~";
            }

            var count = context.SaveChanges();

            Console.WriteLine(count);
        }
    }
}
