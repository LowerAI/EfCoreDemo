


# NuGet引用包列表
+ EfCoreDemo.App必须：
  + Microsoft.EntityFrameworkCore.Design
  
+ EfCoreDemo.Data必须：
  + Microsoft.EntityFrameworkCore.SqlServer
  + Microsoft.EntityFrameworkCore.Tools
  + Microsoft.Extensions.Logging.Console

+ EfCoreDemo.Domain必须：
  + System.ComponmentModel.Annotations

# 迁移命令
+ EfCoreDemo.Data必须
  + add-migration initial              首次迁移
  + update-database -verbose           生成到数据库(带详细信息输出)
  + Add-Migration ChangeSomeProperties 第二次迁移
  + update-database                    生成到数据库
  + add-migration addGame              第三次迁移
  + update-database                    生成到数据库
  + Add-Migration AddOneToOne          第四次迁移
  + Update-Database                    生成到数据库
  + Add-Migration AddResume            第五次迁移
  + Update-Database                    生成到数据库
  + Add-Migration AddGameToContext     第六次迁移
  + Update-Database                    生成到数据库