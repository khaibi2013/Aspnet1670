using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class khai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "detail",
                table: "Books",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "a98a3878-9697-4d1b-97b0-9a33f83509b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "09355713-3a20-46d3-956b-f46c09478ff6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "55492428-b4a6-43d5-ac90-4b3858afed92");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca0cd8cf-9582-45e1-997c-335a273f6580", "AQAAAAEAACcQAAAAEBO4tpZ4raW20QxiHykSUBhHSphYGVYz2oBjphKtVp6pXVkoVGjwU4QPZAO1yREt2Q==", "daf22142-b1c7-4565-ac8e-e06814268d75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64e6f7de-8770-4b5e-b635-c765b6cba84f", "AQAAAAEAACcQAAAAEN5QA2yKdABtsea4Mds3pJ7qTTcTiYEyS7isx91/8aUrbhcZgvby0oi3TGIVb7fxsw==", "8e5ff4b2-0f70-4c3e-9969-97305b4a2bd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e118e4ff-f534-49f4-a7b5-b56892d60001", "AQAAAAEAACcQAAAAEMBfuPZcBTGGyh5E9tU3oNaBECA/3102Lxy+a1sDrCaJ6e/hjadJMS4iyPOukaPXUg==", "8cac4cdd-4880-4912-a405-e691f24b1e11" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datee",
                value: new DateTime(2022, 12, 17, 22, 7, 40, 994, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Datee",
                value: new DateTime(2022, 12, 17, 22, 7, 40, 995, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Datee",
                value: new DateTime(2022, 12, 17, 22, 7, 40, 995, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Datee",
                value: new DateTime(2022, 12, 17, 22, 7, 40, 995, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Datee",
                value: new DateTime(2022, 12, 17, 22, 7, 40, 995, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Datee",
                value: new DateTime(2022, 12, 17, 22, 7, 40, 995, DateTimeKind.Local).AddTicks(405));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "detail",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "1b24e2e3-0cfc-4bc3-b51e-ff97c21a9775");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "b5f9174a-e03c-4355-8b5e-fda043d6f7c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "3195879e-7658-4d42-adca-5f9126fee5d3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa77e090-ed10-4de6-a132-b64697c422cf", "AQAAAAEAACcQAAAAEGWcLj8IxKP93Mdjrcc8evoMFobroNdd0awWS/FbMmeiKGeVMAJI3CN/aFMdEJtw5g==", "f4dc48c4-4eb4-492d-8312-6bdfff248929" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6abd3b17-caaf-431d-8310-a4ceee6384ea", "AQAAAAEAACcQAAAAEB8QOVy6IUoRKZfh9hxGcsm3Kx/fBR6qxRHOBVV20wkQ1+F2QtRdlDwrz0MKv8Rl/g==", "1ab32989-83c8-42ae-aced-ceb58570d855" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c422e8b4-ce3c-4b58-bafd-5f7622bb3779", "AQAAAAEAACcQAAAAEFdKdBHEJhvMKzUhcyjbxu9TotwRJ5o84q6UUtf7O0fGf1HuM2uqi5XKLNTW49qR0w==", "c9c1a41d-a88a-4611-af20-4b32014b8d1a" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datee",
                value: new DateTime(2022, 12, 15, 16, 14, 41, 369, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Datee",
                value: new DateTime(2022, 12, 15, 16, 14, 41, 370, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Datee",
                value: new DateTime(2022, 12, 15, 16, 14, 41, 370, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Datee",
                value: new DateTime(2022, 12, 15, 16, 14, 41, 370, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Datee",
                value: new DateTime(2022, 12, 15, 16, 14, 41, 370, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Datee",
                value: new DateTime(2022, 12, 15, 16, 14, 41, 370, DateTimeKind.Local).AddTicks(5887));
        }
    }
}
