using System;
using System.Collections.Generic;

namespace DataBaseWriteAndLoad.Models;

public partial class Operations
{
    public int ID { get; set; }

    public string CreateID { get; set; } = null!;

    public DateOnly? CreatDate { get; set; }

    public DateOnly? ModifyDate { get; set; }

    public string? ModifyEmployeeID { get; set; }

    public string? Open_ { get; set; }

    public string? Speed { get; set; }

    public string? Optimization { get; set; }
}
