namespace ETHWallets.Server.Utils;

/// <summary>
/// Логика формирования строки подключения к Sepolia (ETH) сервису.
/// </summary>
public static class InfuraConnectionKeys
{
    public static String BaseUrl { get; private set; } = "https://mainnet.infura.io/";

    public static String ApiVersion { get; private set; } = "v3/";

    public static String ApiKey { get; private set; } = "4f05f86f6bcb486e924a9c29e837f73d";

    /// <summary>
    /// Формирует строку подключения к Sepolia сервису.
    /// </summary>
    /// <returns>Строка подключения к Sepolia сервису.</returns>
    public static String GetInfuraApiConnectionString()
    {
        return new String(
            $"{BaseUrl}" +
            $"{ApiVersion}" +
            $"{ApiKey}"
            );
    }
}