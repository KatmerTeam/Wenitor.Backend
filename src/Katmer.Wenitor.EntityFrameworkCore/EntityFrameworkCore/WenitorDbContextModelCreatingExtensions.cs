using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;

namespace Katmer.Wenitor.EntityFrameworkCore
{
    public static class WenitorDbContextModelCreatingExtensions
    {
        public static void ConfigureWenitor(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<TargetSource>(b =>
            {
                b.ToTable(WenitorConsts.DbTablePrefix + "TargetSources", WenitorConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
                b.Property(x => x.Title).IsRequired().HasMaxLength(256);
                b.Property(x => x.WebURL).IsRequired().HasMaxLength(512);
            });

            builder.Entity<TargetSelector>(b =>
            {
                b.ToTable(WenitorConsts.DbTablePrefix + "TargetSelectors", WenitorConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.ExpressionString).IsRequired().HasMaxLength(512);
            });

            builder.Entity<Alert>(b =>
            {
                b.ToTable(WenitorConsts.DbTablePrefix + "Alerts", WenitorConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Detail1).IsRequired().HasMaxLength(512);
            });

            builder.Entity<ScheduleCheck>(b =>
            {
                b.ToTable(WenitorConsts.DbTablePrefix + "ScheduleChecks", WenitorConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Duration).IsRequired();
            });
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser : class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}