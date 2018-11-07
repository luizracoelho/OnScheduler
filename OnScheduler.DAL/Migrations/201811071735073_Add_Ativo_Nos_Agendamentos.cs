namespace OnScheduler.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Ativo_Nos_Agendamentos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Agendamentos", "Ativo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Agendamentos", "Ativo");
        }
    }
}
