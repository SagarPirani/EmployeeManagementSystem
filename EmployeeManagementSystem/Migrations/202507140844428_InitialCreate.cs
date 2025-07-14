namespace EmployeeManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        DesignationID = c.Int(nullable: false, identity: true),
                        DesignationTitle = c.String(),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DesignationID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        EmployeeContactNo = c.String(),
                        EmployeeGander = c.String(),
                        EmployeeSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EmployeeJoinDate = c.DateTime(nullable: false),
                        EmployeePhoto = c.String(),
                        DepartmentID = c.Int(nullable: false),
                        DesignationID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID)
                .ForeignKey("dbo.Designations", t => t.DesignationID)
                .Index(t => t.DepartmentID)
                .Index(t => t.DesignationID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DesignationID", "dbo.Designations");
            DropForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Designations", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DesignationID" });
            DropIndex("dbo.Employees", new[] { "DepartmentID" });
            DropIndex("dbo.Designations", new[] { "DepartmentID" });
            DropTable("dbo.Employees");
            DropTable("dbo.Designations");
            DropTable("dbo.Departments");
        }
    }
}
