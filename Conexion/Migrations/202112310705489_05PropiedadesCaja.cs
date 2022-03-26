namespace Conexion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _05PropiedadesCaja : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cajas", "NEmpleadoApertura", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Cajas", "AEmpleadoApertura", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Cajas", "NEmpleadoCierre", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Cajas", "AEmpleadoCierre", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Cajas", "EstadoCaja", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cajas", "EstadoCaja");
            DropColumn("dbo.Cajas", "AEmpleadoCierre");
            DropColumn("dbo.Cajas", "NEmpleadoCierre");
            DropColumn("dbo.Cajas", "AEmpleadoApertura");
            DropColumn("dbo.Cajas", "NEmpleadoApertura");
        }
    }
}
