using System;
using System.Collections.Generic;

namespace DataBaseWriteAndLoad.Models;

public partial class Shippers1
{
    public int ShipperID { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? Phone { get; set; }
}
