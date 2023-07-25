namespace CloudlyEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'344239ba-800d-4521-b273-07a316eb00a5', N'admin@cloudly.com', 0, N'ANkn3WBjsLD2OriZxAhh8XwueZg/OY4+im+zm2j4zuq+DvTwod8HWq7+bC4EXPvlCQ==', N'afe4a47a-e0e1-4f49-8a88-659881c549c5', NULL, 0, 0, NULL, 1, 0, N'admin@cloudly.com')
            INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'f1e788f3-f162-4c79-a578-ceb151f2a179', N'guest@cloudly.com', 0, N'AON0wtT6DZBzTap9wXw60chl23jxr4McdM/ckEiziNEkxtrQIMR4evHjjaiuIV0SAg==', N'b6c403ec-b9e3-4d6e-bf4b-c00a8f692aa4', NULL, 0, 0, NULL, 1, 0, N'guest@cloudly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'44938937-5ee4-48f3-86b7-b4d465082f10', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'344239ba-800d-4521-b273-07a316eb00a5', N'44938937-5ee4-48f3-86b7-b4d465082f10')
            ");
        }

        public override void Down()
        {
        }
    }
}
