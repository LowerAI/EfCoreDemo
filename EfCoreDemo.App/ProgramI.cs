using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 添加关系数据2
    /// 修改之前必须先查询到内存(可以被追踪)
    /// </summary>
    class ProgramI
    {
        static void MainI(string[] args)
        {
            using var context = new DemoContext();

            var juventus = context.Clubs.Single(x => x.Name == "Juventus");

            // 写法一
            //juventus.Players.Add(new Player
            //{
            //    Name = "Gonzalo Higuain",
            //    DateOfBirth = new DateTime(1987, 12, 10)
            //});

            //int count = context.SaveChanges();

            // 写法二
            juventus.Players.Add(new Player
            {
                //Name = "Matthijs de Ligt",
                Name = "Miralem Pjanic",
                DateOfBirth = new DateTime(1990, 4, 2)
            });

            using var newContext = new DemoContext();
            //newContext.Clubs.Update(juventus); // 此时会导致不必要的update操作
            newContext.Clubs.Attach(juventus); // 此时不会导致不必要的update操作

            int count = newContext.SaveChanges();

            Console.WriteLine(count);
        }
    }
}
