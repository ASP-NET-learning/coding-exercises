using System;
using System.Collections.Generic;

namespace DataBaseWriteAndLoad.Models;

public partial class Machine
{
    public int ID { get; set; }

    public string CreateID { get; set; } = null!;

    public DateOnly? CreatDate { get; set; }

    public DateOnly? ModifyDate { get; set; }

    public string? ModifyEmployeeID { get; set; }

    public string MachineID { get; set; } = null!;

    public string? MachineClass { get; set; }

    public string? MachineName { get; set; }

    public string? SupervisorID { get; set; }

    public string? EmployeeName { get; set; }

    public string? DepartmentName { get; set; }

    public DateOnly? AddTime { get; set; }
}
