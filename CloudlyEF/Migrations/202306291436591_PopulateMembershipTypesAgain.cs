namespace CloudlyEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypesAgain : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes SET SignUpFee = 0 Where Id = 1;");
            Sql("Update MembershipTypes SET SignUpFee = 30 Where Id = 2;");
            Sql("Update MembershipTypes SET SignUpFee = 90 Where Id = 3;");
            Sql("Update MembershipTypes SET SignUpFee = 300 Where Id = 4;");


        }

        public override void Down()
        {
        }
    }
}
