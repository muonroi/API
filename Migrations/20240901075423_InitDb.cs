using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MLanguages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    UpdatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "REAL", nullable: false),
                    LastModificationTimeTs = table.Column<double>(type: "REAL", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "REAL", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatorUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastModifierUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeleterUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Icon = table.Column<string>(type: "TEXT", maxLength: 128, nullable: true),
                    IsDisabled = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MLanguages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MPermissions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    UpdatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "REAL", nullable: false),
                    LastModificationTimeTs = table.Column<double>(type: "REAL", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "REAL", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatorUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastModifierUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeleterUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    IsGranted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    UpdatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "REAL", nullable: false),
                    LastModificationTimeTs = table.Column<double>(type: "REAL", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "REAL", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatorUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastModifierUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeleterUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    DisplayName = table.Column<string>(type: "TEXT", nullable: false),
                    IsStatic = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDefault = table.Column<bool>(type: "INTEGER", nullable: false),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MUserAccounts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    UpdatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "REAL", nullable: false),
                    LastModificationTimeTs = table.Column<double>(type: "REAL", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "REAL", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatorUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastModifierUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeleterUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UserId = table.Column<long>(type: "INTEGER", nullable: false),
                    UserLinkId = table.Column<long>(type: "INTEGER", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    EmailAddress = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MUserAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MUserLoginAttempts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    UpdatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "REAL", nullable: false),
                    LastModificationTimeTs = table.Column<double>(type: "REAL", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "REAL", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatorUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastModifierUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeleterUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UserId = table.Column<long>(type: "INTEGER", nullable: true),
                    UserNameOrEmailAddress = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    ClientIpAddress = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    ClientName = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    BrowserInfo = table.Column<string>(type: "TEXT", maxLength: 512, nullable: false),
                    Result = table.Column<byte>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MUserLoginAttempts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MUserLogins",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    UpdatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "REAL", nullable: false),
                    LastModificationTimeTs = table.Column<double>(type: "REAL", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "REAL", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatorUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastModifierUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeleterUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UserId = table.Column<long>(type: "INTEGER", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MUserLogins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MUserRoles",
                columns: table => new
                {
                    EntityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    UpdatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "REAL", nullable: false),
                    LastModificationTimeTs = table.Column<double>(type: "REAL", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "REAL", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatorUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastModifierUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeleterUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UserId = table.Column<long>(type: "INTEGER", nullable: false),
                    RoleId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "MUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    UpdatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "REAL", nullable: false),
                    LastModificationTimeTs = table.Column<double>(type: "REAL", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "REAL", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatorUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastModifierUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeleterUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ProfilePictureId = table.Column<int>(type: "INTEGER", nullable: true),
                    ShouldChangePasswordOnNextLogin = table.Column<bool>(type: "INTEGER", nullable: false),
                    SignInTokenExpireTimeUtc = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SignInToken = table.Column<string>(type: "TEXT", nullable: true),
                    GoogleAuthenticatorKey = table.Column<string>(type: "TEXT", nullable: true),
                    RecoveryCode = table.Column<string>(type: "TEXT", nullable: true),
                    AuthenticationSource = table.Column<string>(type: "TEXT", maxLength: 64, nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    EmailAddress = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Surname = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    EmailConfirmationCode = table.Column<string>(type: "TEXT", maxLength: 328, nullable: true),
                    PasswordResetCode = table.Column<string>(type: "TEXT", maxLength: 328, nullable: true),
                    LockoutEndDateUtc = table.Column<DateTime>(type: "TEXT", nullable: true),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false),
                    IsLockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 32, nullable: false),
                    IsPhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    SecurityStamp = table.Column<string>(type: "TEXT", maxLength: 128, nullable: true),
                    IsTwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    NormalizedEmailAddress = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 128, nullable: true),
                    Salf = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MUserTokens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletedUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    UpdatedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DeletedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedDateTS = table.Column<double>(type: "REAL", nullable: false),
                    LastModificationTimeTs = table.Column<double>(type: "REAL", nullable: true),
                    DeletedDateTS = table.Column<double>(type: "REAL", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatorUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastModifierUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeleterUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UserId = table.Column<long>(type: "INTEGER", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MUserTokens", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MLanguages_Name",
                table: "MLanguages",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MPermissions_Name",
                table: "MPermissions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MRoles_Name",
                table: "MRoles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MUserAccount_UserName",
                table: "MUserAccounts",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MUserLoginAttempt_UserNameOrEmailAddress",
                table: "MUserLoginAttempts",
                column: "UserNameOrEmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_MUserLogin_UserId",
                table: "MUserLogins",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MUser_UserName",
                table: "MUsers",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MUserToken_LoginProvider",
                table: "MUserTokens",
                column: "LoginProvider");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MLanguages");

            migrationBuilder.DropTable(
                name: "MPermissions");

            migrationBuilder.DropTable(
                name: "MRoles");

            migrationBuilder.DropTable(
                name: "MUserAccounts");

            migrationBuilder.DropTable(
                name: "MUserLoginAttempts");

            migrationBuilder.DropTable(
                name: "MUserLogins");

            migrationBuilder.DropTable(
                name: "MUserRoles");

            migrationBuilder.DropTable(
                name: "MUsers");

            migrationBuilder.DropTable(
                name: "MUserTokens");
        }
    }
}
