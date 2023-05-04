using ETHWallets.Server.Data;
using ETHWallets.Server.Utils;
using ETHWallets.Shared.Models;

namespace ETHWallets.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WalletController : ControllerBase
{
    /// <summary>
    /// Получает баланс ETH-кошельков.
    /// </summary>
    /// <returns>Перечислитель моделей кошельков.</returns>
    [HttpGet]
    public async Task<IEnumerable<Wallet>> Get()
    {
        var wallets = new List<Wallet>();

        using (var _context = new WalletsContext())
        {
            // Получить список кошельков из базы данных.
            wallets = _context.Wallets.ToList();

            var tasks = new List<Task>();

            foreach (var wallet in wallets)
            {
                tasks.Add(Task.Run(async () =>
                {
                    wallet.Balance = await EthereumTool.GetWalletBalance(wallet.Address);
                }));
            }

            await Task.WhenAll(tasks);
        }

        return wallets;
    }
}