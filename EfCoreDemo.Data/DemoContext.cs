using EfCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace EfCoreDemo.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext()
        {
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; // 设置执行DbContext操作时全局不追踪
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseLoggerFactory(ConsoleLoggerFactory) // 输出日志到控制台
                .EnableSensitiveDataLogging() // 在控制台中显示SQL语句的参数值
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Demo");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<GamePlayer>().HasKey(x => new { x.PlayerId, x.GameId }); // 设置联合主键
            modelBuilder.Entity<Resume>()
                .HasOne(x => x.Player)
                .WithOne(x => x.Resume)
                .HasForeignKey<Resume>(x => x.PlayerId); // 设置外键

            modelBuilder.Entity<PlayerClub>()
                .HasNoKey()  // 设置为无主键
                .ToView("PlayerClubView"); // 映射到视图
        }

        public DbSet<League> Leagues { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<PlayerClub> PlayerClubs { get; set; }

        public static readonly ILoggerFactory ConsoleLoggerFactory =
            LoggerFactory.Create(builder =>
            {
                // 把执行的SQL命令语句输出到控制台方便查看
                builder.AddFilter((category, level) => category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information)
                .AddConsole();
            });
    }
}
