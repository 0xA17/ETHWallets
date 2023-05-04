namespace ETHWallets.Server.Utils;

/// <summary>
/// Логика формирования строки подключения к БД.
/// </summary>
public static class DbConnectionKeys
{
    public static String Host { get; private set; } = "localhost";
    public static String User { get; private set; } = "postgres";
    public static String DbName { get; private set; } = "ETHWallets";
    public static String Password { get; private set; } = "123";
    public static String Port { get; private set; } = "5432";

    /// <summary>
    /// Формирует строку подключения к базе данных.
    /// </summary>
    /// <returns>Строка подключения к базе дынных.</returns>
    public static String GetConnectionString()
    {
        return new String(
            $"Server={Host};" +
            $"Username={User};" +
            $"Database={DbName};" +
            $"Port={Port};" +
            $"Password={Password};"
            );
    }
}
