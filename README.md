# ETHWallets

## О проекте

ETHWallets - это простой Blazor проект, в котором можно моментально просматривать информацию о ETH-кошельках.

## Начало работы

### 1. Запуск проекта

Скачиваем исходный код проекта или выполняем команду:

```
git clone https://github.com/0xA17/ETHWallets -recursive
```

### 2.	Установка зависимостей программного обеспечения

```
dotnet add package Microsoft.AspNetCore.Components.WebAssembly.Server --version 5.0.17
dotnet add package Microsoft.EntityFrameworkCore.Relational --version 7.0.5
dotnet add package Nethereum.Web3 --version 4.14.0
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 7.0.4

```

### 3.	Установка PostgreSQL

Переходим на [официальный сайт PostgreSQL](https://www.enterprisedb.com/downloads/postgres-postgresql-downloads) и скачиваем пакеты, которые подходят для вашей ОС.


### 4.	Настройка строки подключения

В файле [DbConnectionKeys.cs](https://github.com/0xA17/ETHWallets/blob/master/ETHWallets/Server/Utils/DbConnectionKeys.cs) необходимо проверить данные на корректность, совпадают ли данные с вашими, которые устанавливали при загрузке PostgreSQL:

```csharp
public static class DbConnectionKeys
{
    public static String Host { get; private set; } = "localhost";
    public static String User { get; private set; } = "postgres";
    public static String DbName { get; private set; } = "ETHWallets";
    public static String Password { get; private set; } = "123";
    public static String Port { get; private set; } = "5432";

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
```

### 5. Запуск

Компилируем, запускаем проект и наблюдаем информацию о кошельках, которые добавлены в базу данных.

<p align="center">
    <img align="center" src="https://telegra.ph/file/e25fef5f2a419aac42d88.png">
</p>

### 6. Заполнение демонстрационных данных

Чтобы проверить работу сервиса можно заполнить БД кошельками, выполнив в вашей базе данных скрипт из файла [wallets.sql](https://github.com/0xA17/ETHWallets/blob/master/wallets.sql)

## Участие
Некоторые из лучших способов внести свой вклад — попробовать что-то, зарегистрировать проблемы, присоединиться к обсуждениям дизайна и сделать запросы на вытягивание.

Есть много способов, которыми вы можете участвовать в этом проекте, например:

* Отправляйте сообщения об ошибках и запросы функций и помогайте нам проверять их по мере их регистрации.
* Просмотр изменений исходного кода
* Просмотрите документацию и отправьте запросы на вытягивание для всего, от опечаток до дополнительного и нового контента.