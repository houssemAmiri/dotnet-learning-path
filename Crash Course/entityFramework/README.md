### 🔸  Entity Framework Core Preview (2 hours)

**🧠 Focus On:**

- What is an ORM?
- What is DbContext and DbSet?
- Migration vs Seeding vs CRUD
- EF Core annotations: `[Key]`, `[Required]`, `[ForeignKey]`

**👨‍💻 Example:**

```csharp
public class AppDbContext : DbContext {
    public DbSet<TaskItem> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=tasks.db");
}
```

**Tools:**

```bash
dotnet ef migrations add Init
dotnet ef database update
```

**Don’t build a full app yet — just explore how models + DbContext interact.**
