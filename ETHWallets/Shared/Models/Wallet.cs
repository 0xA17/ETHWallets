using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETHWallets.Shared.Models;

public class Wallet
{
    public Int32 Id { get; set; }

    public String Address { get; set; }

    [NotMapped]
    public Decimal Balance { get; set; }
}