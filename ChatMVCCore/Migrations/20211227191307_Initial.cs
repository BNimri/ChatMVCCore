using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatMVCCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessageDetailsModel",
                columns: table => new
                {
                    MessageRecordID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageType = table.Column<int>(nullable: false),
                    MessageContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageDetailsModel", x => x.MessageRecordID);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    RecordID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender = table.Column<string>(nullable: true),
                    Receiver = table.Column<string>(nullable: true),
                    MessageDetailsMessageRecordID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.RecordID);
                    table.ForeignKey(
                        name: "FK_Messages_MessageDetailsModel_MessageDetailsMessageRecordID",
                        column: x => x.MessageDetailsMessageRecordID,
                        principalTable: "MessageDetailsModel",
                        principalColumn: "MessageRecordID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_MessageDetailsMessageRecordID",
                table: "Messages",
                column: "MessageDetailsMessageRecordID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "MessageDetailsModel");
        }
    }
}
