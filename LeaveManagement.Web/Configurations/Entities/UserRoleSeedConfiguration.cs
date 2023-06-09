using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "46c743da-ca3d-4f70-afa7-f189dbff4ba0",
                    UserId = "e49865a3-78b1-4ea6-8936-20b2a9831938"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "4ca84589-4e6b-4f51-b598-ff541ecb40af",
                    UserId = "c5311496-09bb-4e58-ad1a-ad2f5f52ce14"
                }
             );
        }
    }
}