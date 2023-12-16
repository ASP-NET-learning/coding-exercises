using System;
using System.Collections.Generic;

namespace DataBaseWriteAndLoad.Models;

public partial class Ai
{
    public int ID { get; set; }

    public string CreateID { get; set; } = null!;

    public DateOnly? CreatDate { get; set; }

    public DateOnly? ModifyDate { get; set; }

    public string? ModifyEmployeeID { get; set; }

    public string? MachineID { get; set; } = null;

    public string? AlgorithmName { get; set; }

    public string? HyperparameterName { get; set; }

    public string? CrossName { get; set; }
}
