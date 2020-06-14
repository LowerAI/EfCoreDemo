using EfCoreDemo.Data;
using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreDemo.App
{
    /// <summary>
    /// 执行原生SQL2
    /// </summary>
    class ProgramT
    {
        static void Main(string[] args)
        {
            using var context = new DemoContext();

            var count = context.Database
                .ExecuteSqlRaw("EXEC dbo.RemoveGamePlayersProcedure {0}", 2);

            count = context.Database
                .ExecuteSqlInterpolated($"EXEC dbo.RemoveGamePlayersProcedure {2}");
        }
    }
}
