﻿using System;
using System.Collections.Generic;

namespace DataConnectPractise.Models;

public partial class Products_Above_Average_Price
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
