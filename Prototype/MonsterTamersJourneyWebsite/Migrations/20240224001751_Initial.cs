using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MonsterTamersJourneyWebsite.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Creator",
                columns: table => new
                {
                    CreatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentPlatforms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialAccounts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutYou = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestKey = table.Column<bool>(type: "bit", nullable: false),
                    OtherRequests = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creator", x => x.CreatorId);
                });

            migrationBuilder.CreateTable(
                name: "FAQ",
                columns: table => new
                {
                    FAQId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQ", x => x.FAQId);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    MediaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isImage = table.Column<bool>(type: "bit", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.MediaId);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsId);
                });

            migrationBuilder.CreateTable(
                name: "Press",
                columns: table => new
                {
                    PressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutletName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainChannel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwitterHandel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutletCatagory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestKey = table.Column<bool>(type: "bit", nullable: false),
                    OtherRequests = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Press", x => x.PressId);
                });

            migrationBuilder.CreateTable(
                name: "SupportRequest",
                columns: table => new
                {
                    SupportRequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupportEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportRequest", x => x.SupportRequestId);
                });

            migrationBuilder.InsertData(
                table: "Creator",
                columns: new[] { "CreatorId", "AboutYou", "ContentPlatforms", "CreatorName", "Email", "OtherRequests", "PreferedName", "RequestKey", "SocialAccounts" },
                values: new object[] { 1, "I do Cool Stuff!", "YouTube, Facebook", "Joe", "cherryinatree@gmail.com", "Can I get merch bro?", "Joey", true, "Facebook" });

            migrationBuilder.InsertData(
                table: "FAQ",
                columns: new[] { "FAQId", "Content", "Order", "Title" },
                values: new object[] { 1, "Have you tried [blank]?", 1, "Why won't my game [blank]?" });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "ImageUrl", "Order", "Title", "VideoUrl", "isImage" },
                values: new object[,]
                {
                    { 1, "https://dl.dropboxusercontent.com/scl/fi/cnc0ycr7fm4fg4kpho5sd/InGame2.png?rlkey=ypkf1i0vruzv6zawgafgdam70&dl=0", 1, "Trailer", "https://youtu.be/uv6HXgWBnfw?si=gilVtCnkw8a7cweT", false },
                    { 2, "https://dl.dropboxusercontent.com/scl/fi/cnc0ycr7fm4fg4kpho5sd/InGame2.png?rlkey=ypkf1i0vruzv6zawgafgdam70&dl=0", 2, "Trailer", "https://youtu.be/uv6HXgWBnfw?si=gilVtCnkw8a7cweT", true }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "NewsId", "Content", "ImageUrl", "Order", "Title" },
                values: new object[] { 1, "The Website is now live!", "https://dl.dropboxusercontent.com/scl/fi/cnc0ycr7fm4fg4kpho5sd/InGame2.png?rlkey=ypkf1i0vruzv6zawgafgdam70&dl=0", 1, "Website Released" });

            migrationBuilder.InsertData(
                table: "Press",
                columns: new[] { "PressId", "Email", "MainChannel", "OtherRequests", "OutletCatagory", "OutletName", "RequestKey", "TwitterHandel", "name" },
                values: new object[] { 1, "cherryinatree@gmail.com", "Twitter", "I'd like an interview.", "Digital Media", "Big Press", true, "JornoWorksForBigPress", "Jurno" });

            migrationBuilder.InsertData(
                table: "SupportRequest",
                columns: new[] { "SupportRequestId", "Question", "Subject", "SupportEmail" },
                values: new object[] { 1, "I've tried X, Y, and Z. What should I do?", "My game won't load level 3", "cherryinatree@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Creator");

            migrationBuilder.DropTable(
                name: "FAQ");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Press");

            migrationBuilder.DropTable(
                name: "SupportRequest");
        }
    }
}
