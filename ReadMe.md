


# NuGet���ð��б�
+ EfCoreDemo.App���룺
  + Microsoft.EntityFrameworkCore.Design
  
+ EfCoreDemo.Data���룺
  + Microsoft.EntityFrameworkCore.SqlServer
  + Microsoft.EntityFrameworkCore.Tools
  + Microsoft.Extensions.Logging.Console

+ EfCoreDemo.Domain���룺
  + System.ComponmentModel.Annotations

# Ǩ������
+ EfCoreDemo.Data����
  + add-migration initial              �״�Ǩ��
  + update-database -verbose           ���ɵ����ݿ�(����ϸ��Ϣ���)
  + Add-Migration ChangeSomeProperties �ڶ���Ǩ��
  + update-database                    ���ɵ����ݿ�
  + add-migration addGame              ������Ǩ��
  + update-database                    ���ɵ����ݿ�
  + Add-Migration AddOneToOne          ���Ĵ�Ǩ��
  + Update-Database                    ���ɵ����ݿ�
  + Add-Migration AddResume            �����Ǩ��
  + Update-Database                    ���ɵ����ݿ�
  + Add-Migration AddGameToContext     ������Ǩ��
  + Update-Database                    ���ɵ����ݿ�