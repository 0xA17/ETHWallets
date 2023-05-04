using Nethereum.Web3;

namespace ETHWallets.Server.Utils;

/// <summary>
/// Логика взаимодействия для библиотеки Nethereum.
/// </summary>
public static class EthereumTool
{
    /// <summary>
    /// Получает баланс Ethereum кошелька.
    /// </summary>
    /// <param name="walletAddress">Адрес кошелька.</param>
    /// <returns>Баланс заданного кошелька.</returns>
    /// <exception cref="ArgumentNullException">Адрес кошелька является нулевым или пустым.</exception>
    public async static Task<Decimal> GetWalletBalance(String walletAddress)
    {
        if (String.IsNullOrEmpty(walletAddress))
        {
            throw new ArgumentNullException(nameof(walletAddress));
        }

        //Используем Ethereum.Web3 для получения баланса кошелька.
        var balance = await new Web3(InfuraConnectionKeys.GetInfuraApiConnectionString())?.
            Eth.GetBalance.SendRequestAsync(walletAddress) ?? null;

        return Web3.Convert.FromWei(balance?.Value ?? Byte.MinValue);
    }
}