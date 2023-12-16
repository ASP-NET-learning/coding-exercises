using System;
using System.Collections.Generic;

namespace DataBaseWriteAndLoad.Models;

public partial class NetWork
{
    public int ID { get; set; }

    public string CreateID { get; set; } = null!;

    public DateOnly? CreatDate { get; set; }

    public DateOnly? ModifyDate { get; set; }

    public string? ModifyEmployeeID { get; set; }

    public string? WifiSSID { get; set; }

    public string? WifiPassword { get; set; }

    public string? IpAddress { get; set; }

    public string? SubnetMask { get; set; }

    public string? Gateway { get; set; }

    public string? Dns { get; set; }
}
