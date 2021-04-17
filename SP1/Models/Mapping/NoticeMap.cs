using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class NoticeMap : EntityTypeConfiguration<Notice>
    {
        public NoticeMap()
        {
            // Primary Key
            this.HasKey(t => t.NoticeId);

            // Properties
            this.Property(t => t.NoticeSubject)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Notice1)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Notice");
            this.Property(t => t.NoticeId).HasColumnName("NoticeId");
            this.Property(t => t.NoticeSubject).HasColumnName("NoticeSubject");
            this.Property(t => t.Notice1).HasColumnName("Notice");
            this.Property(t => t.NoticeDate).HasColumnName("NoticeDate");
        }
    }
}
