namespace OnScheduler.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Descricao_Agendamento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Agendamentos", "Descricao", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Agendamentos", "Descricao");
        }
    }
}
