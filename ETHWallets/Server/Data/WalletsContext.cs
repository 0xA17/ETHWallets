using ETHWallets.Server.Utils;
using ETHWallets.Shared.Models;

namespace ETHWallets.Server.Data;

public class WalletsContext : DbContext
{
    public DbSet<Wallet> Wallets { get; set; }

    public WalletsContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(DbConnectionKeys.GetConnectionString());
    }
}