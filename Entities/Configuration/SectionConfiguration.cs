using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasData
            (
                new Section
                {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991872"),
                    SectionName = "012",
                },
                new Section
                {
                    Id = new Guid("3d490a70-94tretre5-9494-524fertr2ce2"),
                    SectionName = "Sectioncsfffcc
                }t
            );
        }
    }
}