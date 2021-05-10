using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class addedinversenavigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseLines_ExpenseHeaders_ExpenseHeaderId",
                table: "ExpenseLines");

            migrationBuilder.AlterColumn<int>(
                name: "ExpenseHeaderId",
                table: "ExpenseLines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseLines_ExpenseHeaders_ExpenseHeaderId",
                table: "ExpenseLines",
                column: "ExpenseHeaderId",
                principalTable: "ExpenseHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseLines_ExpenseHeaders_ExpenseHeaderId",
                table: "ExpenseLines");

            migrationBuilder.AlterColumn<int>(
                name: "ExpenseHeaderId",
                table: "ExpenseLines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseLines_ExpenseHeaders_ExpenseHeaderId",
                table: "ExpenseLines",
                column: "ExpenseHeaderId",
                principalTable: "ExpenseHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
