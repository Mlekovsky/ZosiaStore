using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Persistence.Configurations
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.ToTable(nameof(News));

            builder.Property(x => x.BeginDate)
                .IsRequired();

            builder.Property(x => x.ExpireDate)
                .IsRequired();

            builder.Property(x => x.Message)
                .IsRequired();
        }
    }
}
