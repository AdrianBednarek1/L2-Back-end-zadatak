﻿namespace Project.Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SQLEXPRESS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VehicleMakes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Abrv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VehicleModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Abrv = c.String(),
                        MakeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VehicleMakes", t => t.MakeId, cascadeDelete: true)
                .Index(t => t.MakeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VehicleModels", "MakeId", "dbo.VehicleMakes");
            DropIndex("dbo.VehicleModels", new[] { "MakeId" });
            DropTable("dbo.VehicleModels");
            DropTable("dbo.VehicleMakes");
        }
    }
}
