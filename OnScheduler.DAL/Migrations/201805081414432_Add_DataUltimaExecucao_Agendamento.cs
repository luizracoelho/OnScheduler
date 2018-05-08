namespace OnScheduler.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_DataUltimaExecucao_Agendamento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Agendamentos", "DataUltimaExecucao", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Agendamentos", "DataUltimaExecucao");
        }
    }
}
