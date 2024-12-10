using InventoryData.Entity;
using Microsoft.EntityFrameworkCore;

namespace InventoryDb;

public class InventoryDbContext(DbContextOptions<InventoryDbContext> options) : DbContext(options)
{
    public DbSet<Inventory> Inventory { get; set; } = default!;
}