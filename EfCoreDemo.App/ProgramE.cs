using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 删除
    /// 删除之前必须先查询到内存
    /// </summary>
    class ProgramE
    {
        static void MainE(string[] args)
        {
            using var context = new DemoContext();

            // Delete
            // 只能删除追踪的数据
            var milan = context.Clubs.Single(x => x.Name == "AC Milan");

            // 调用删除方法
            context.Clubs.Remove(milan);               // 单行删除-写法一
            //context.Remove(milan);                    // 单行删除-写法二

            //context.Clubs.RemoveRange(milan, milan);  // 多行删除-写法三
            //context.RemoveRange(milan, milan);        // 多行删除-写法四

            var count = context.SaveChanges();

            Console.WriteLine(count);
        }
    }
}
