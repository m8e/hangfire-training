using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using APIServer.Domain.Core.Models.WebHooks;

namespace APIServer.Presistence {
    public class WebHookonfiguration : IEntityTypeConfiguration<WebHook> {
        public void Configure(EntityTypeBuilder<WebHook> builder) {

            builder.HasKey(e => e.ID);
            
            builder.HasMany(e => e.Headers)
            .WithOne(e => e.WebHook)
            .HasForeignKey(e => e.WebHookID);

            builder.HasMany(e => e.Records)
            .WithOne(e => e.WebHook)
            .HasForeignKey(e => e.WebHookID);
        }
    }
}