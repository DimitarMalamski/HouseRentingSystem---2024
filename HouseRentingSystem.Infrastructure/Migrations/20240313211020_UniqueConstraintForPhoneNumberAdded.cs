using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5108213-074e-49e5-ab1c-5a4826a91ebc", "AQAAAAEAACcQAAAAEMPwvjlVBKq70ByhTrOtU/cPVm82gzkBhyIlmleZyIZz+qJKQIukT4qxBpYdissmuQ==", "bea314de-c637-49dd-9fee-c0b79217938e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbbed89a-1ab5-4a06-a722-77e119bbc260", "AQAAAAEAACcQAAAAENkz9sicxeU9Bk5OJtbcYIf+1to6beD3+soWYch0tJgnUSNNv5b6D3ZwJO2Mmpz0dg==", "cd9da6f7-61d1-47c0-a385-87c047160dab" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "143846a5-f592-4217-b46a-28ac5a0a27b6", "AQAAAAEAACcQAAAAELEFDExqWRUNBnAvwXwa3JpFNQNClPx5nFAus7d95M+4T6/PisTaAdvR3+by5X2bpQ==", "2bd52b81-bfb3-4196-be53-fad43dcce2c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1204fb67-5362-4fd4-9243-e68b86086c7d", "AQAAAAEAACcQAAAAEEjG8dNDADN4I6WW+fn6YoFh2+Q6RuM7d/gsaWJqMVmbbv6a+UBqacDDclI8z/+3uw==", "6aeb1fb3-affa-4611-a81e-ee261f3435f7" });
        }
    }
}
