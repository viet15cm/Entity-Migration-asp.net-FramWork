namespace EntityText.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        MaLop = c.String(nullable: false, maxLength: 128),
                        TenLop = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaLop);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 128),
                        TenSV = c.String(nullable: false),
                        Lop = c.String(),
                        Lop_MaLop = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaSV)
                .ForeignKey("dbo.Lops", t => t.Lop_MaLop)
                .Index(t => t.Lop_MaLop);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "Lop_MaLop", "dbo.Lops");
            DropIndex("dbo.SinhViens", new[] { "Lop_MaLop" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.Lops");
        }
    }
}
