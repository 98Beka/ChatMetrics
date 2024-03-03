using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL;
public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) {
    }
    public DbSet<TotalChatsReport> TotalChatsReports { get; set; }
    public DbSet<DurationReport> DurationReports { get; set; }
    public DbSet<RatingsReport> RatingsReports { get; set; }
    public DbSet<ResponseTimeReport> ResponseTimeReports { get; set; }
    // Предполагается, что TagsReport - это более сложная структура, возможно, требующая отдельного подхода
    // Но для примера:
    public DbSet<TagsReport> TagsReports { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        // Настройка схемы базы данных, если требуется
        // Например, определение связей, индексов и т.д.

        // Пример:
        modelBuilder.Entity<TotalChatsReport>()
            .HasKey(r => r.Id); // Указываем, что поле Id - это первичный ключ

        // Аналогично настраиваем модели для других DbSet
    }
}