﻿using System;
using System.Collections.Generic;

namespace DataBaseWriteAndLoad.Models;

public partial class Employees
{
    public int EmployeeID { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? Title { get; set; }

    public string? TitleOfCourtesy { get; set; }

    public DateTime? BirthDate { get; set; }

    public DateTime? HireDate { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? HomePhone { get; set; }

    public string? Extension { get; set; }

    public byte[]? Photo { get; set; }

    public string? Notes { get; set; }

    public int? ReportsTo { get; set; }

    public string? PhotoPath { get; set; }

    public int? Salary { get; set; }

    public virtual ICollection<Employees> InverseReportsToNavigation { get; set; } = new List<Employees>();

    public virtual ICollection<Orders> Orders { get; set; } = new List<Orders>();

    public virtual Employees? ReportsToNavigation { get; set; }

    public virtual ICollection<Territories> Territory { get; set; } = new List<Territories>();
}
