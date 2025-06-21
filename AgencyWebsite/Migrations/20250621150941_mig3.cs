using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgencyWebsite.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgUrl1",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "imgUrl2",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "imgUrl3",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "item1",
                table: "SocialMedias");

            migrationBuilder.RenameColumn(
                name: "item3",
                table: "SocialMedias",
                newName: "item");

            migrationBuilder.RenameColumn(
                name: "item2",
                table: "SocialMedias",
                newName: "imgUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "item",
                table: "SocialMedias",
                newName: "item3");

            migrationBuilder.RenameColumn(
                name: "imgUrl",
                table: "SocialMedias",
                newName: "item2");

            migrationBuilder.AddColumn<string>(
                name: "imgUrl1",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "imgUrl2",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "imgUrl3",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "item1",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
