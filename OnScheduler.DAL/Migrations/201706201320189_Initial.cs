namespace OnScheduler.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agendamentos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        TipoSazonalidade = c.Int(),
                        TempoAviso = c.Decimal(precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Datas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DiaSemana = c.Int(nullable: false),
                        Hora = c.Time(nullable: false, precision: 7),
                        AgendamentoDiario_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Agendamentos", t => t.AgendamentoDiario_Id, cascadeDelete: true)
                .Index(t => t.AgendamentoDiario_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Datas", "AgendamentoDiario_Id", "dbo.Agendamentos");
            DropIndex("dbo.Datas", new[] { "AgendamentoDiario_Id" });
            DropTable("dbo.Datas");
            DropTable("dbo.Agendamentos");
        }
    }
}
