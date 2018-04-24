namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5d4806ba-7458-4441-926d-3d901d2fe26d', N'guest@vidly.com', 0, N'AGWNEmMv8eBRhhKgWHJjt95CEGzn0Ux4/smK5c0Wnu7lYgNydhPCKGE7X00hdiu6tA==', N'a1619fa1-1906-478a-9bff-7906374b8f8f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b41b19db-24d4-4eba-8cb9-a6fc285be916', N'admin@vidly.com', 0, N'AD8o1mUckr3kDeawBkbnB3W/mpm8a34vcgprCb4Qe2mAcKIbcecaZvyx3heEltdg2Q==', N'da88b7d0-5211-4a92-b8ef-367d3f07e3a7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4d0d091f-a4c4-413c-b40c-bb04dd6563e8', N'CanManageMovie')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b41b19db-24d4-4eba-8cb9-a6fc285be916', N'4d0d091f-a4c4-413c-b40c-bb04dd6563e8')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
