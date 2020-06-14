using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 修改关联数据1
    /// </summary>
    class ProgramP
    {
        static void MainP(string[] args)
        {
            // league - club - player
            using var context = new DemoContext();

            var club = context.Clubs.Include(x => x.League).First();

            club.League.Name += "@";

            context.SaveChanges();
        }
    }
}
