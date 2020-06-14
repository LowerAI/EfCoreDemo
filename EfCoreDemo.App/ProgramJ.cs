using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 添加关系数据3
    /// 修改之前必须先查询到内存(可以被追踪)
    /// </summary>
    class ProgramJ
    {
        static void MainJ(string[] args)
        {
            // league - club - player
            using var context = new DemoContext();

            var resume = new Resume
            {
                PlayerId = 1, // C.Ronaldo
                Description = "..."
            };

            context.Resumes.Add(resume);
            
            int count = context.SaveChanges();

            Console.WriteLine(count);
        }
    }
}
