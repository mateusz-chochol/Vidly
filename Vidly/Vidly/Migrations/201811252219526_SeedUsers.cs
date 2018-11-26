namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'115738db-993b-4698-8ba9-5675acca89b8', N'admin@vidly.com', 0, N'AAg3LjAlTeHfN19GNTaw0VcL0VIAokCpZcoQUwy8YF6JYr0tQNiVA6GQJDmsZf9TNg==', N'b0d8d884-6551-47f6-999c-f4b16100a3ef', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3ff23dd0-749e-49ed-b139-df3dddb821ab', N'guest@vidly.com', 0, N'AJDmFBbdsscR+XcYvcqdjTkFZKfO+DtGKqA6gUCzqOsdQhQuYBdY8SHsEcvv3ITm4A==', N'f56e95e0-7d53-41be-a75f-49265acbfc87', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'dcf36d1d-b4c4-4459-8040-74af7ff85c6e', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'115738db-993b-4698-8ba9-5675acca89b8', N'dcf36d1d-b4c4-4459-8040-74af7ff85c6e')
");
        }
        
        public override void Down()
        {
        }
    }
}
