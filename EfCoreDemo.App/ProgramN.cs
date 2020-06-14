using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 加载关联数据3
    /// 预加载，Eager loading
    /// 显示加载，、Explicit loading
    /// 懒加载，lazy loading
    /// </summary>
    class ProgramN
    {
        static void MainN(string[] args)
        {
            // league - club - player
            using var context = new DemoContext();

            var info = context.Clubs.First();

            context.Entry(info)
                .Collection(x => x.Players) // 针对关联的集合对象用Collection
                .Load();

            context.Entry(info)
                .Reference(x => x.League)   // 针对关联的单个对象用Reference
                .Load();
        }
    }
}
