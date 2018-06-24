namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                   INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'396aa2d6-c8c5-4987-b5f7-01d7ba0eeacb', N'admin@hotmail.com', 0, N'ACSGW3nx4qtVlhF40B/Ag8UY+ZFVtSQno0QspZDZdTQedvuKA2CyZnVr/3DyIA9Aew==', N'431864bd-6200-471d-82c9-6a89e51cc7df', NULL, 0, 0, NULL, 1, 0, N'admin@hotmail.com')
                   INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9549d12d-0377-412b-8f27-11ec0f7bebae', N'mac.beath@hotmail.com', 0, N'AKmDQLCzCWpkmt2sYB1rrmyYCioNsOEu5t1QRspjBUfAwCnnPb0QJTkq1yiSwNu4Cg==', N'df77fda3-900d-482f-a18a-b79f8a71a147', NULL, 0, 0, NULL, 1, 0, N'mac.beath@hotmail.com')
                   INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'71a18726-c734-41df-b225-d802be486afa', N'CanManageMovies')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
